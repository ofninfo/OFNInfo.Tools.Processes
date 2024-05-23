using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace OFNInfo.Tools.Processes
{
    public partial class MainForm : Form
    {
        class ProcessModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Selected { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ltvProcesses.Columns.Add("ID", 100);
            ltvProcesses.Columns.Add("Nome", 300);
            ltvProcesses.Columns.Add("Memory", 100);

            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ListViewItem> processes = Process.GetProcesses().Where(p => p.ProcessName.ToLower().Contains(txtSearch.Text.ToLower())).Select(p => new ListViewItem(new string[]
            {
                p.Id.ToString(),
                p.ProcessName,
                $"{p.WorkingSet64.ToByteSize()}",
            }, -1)).ToList();

            ltvProcesses.Items.Clear();
            ltvProcesses.Items.AddRange(processes.ToArray());

            btnEndProcess.Enabled = (processes.Count > 0);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void ltvProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnSorter sorter = new ColumnSorter();
            sorter.SortColumn = e.Column;
            sorter.Order = SortOrder.Ascending;
            ltvProcesses.ListViewItemSorter = sorter;
            ltvProcesses.Sort();
        }

        private async void btnEndProcess_Click(object sender, EventArgs e)
        {


            if (bwkMainWork.IsBusy != true)
            {
                List<ProcessModel> processes = new List<ProcessModel>();

                foreach (ListViewItem item in ltvProcesses.Items)
                {
                    processes.Add(new ProcessModel()
                    {
                        Id = Convert.ToInt32(item.Text),
                        Name = item.SubItems[0].Text,
                        Selected = item.Selected
                    });
                }

                List<ProcessModel> processesSelecteds = processes.Where(p => p.Selected).ToList();

                if (processesSelecteds != null && processesSelecteds.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to close these selected processes?\n\nATTENTION: This action may compromise the proper functioning of the system.",
                        "Confirmation of Closure of Processes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        bwkMainWork.RunWorkerAsync(processesSelecteds);

                        btnEndProcess.Enabled = false;
                        btnCancel.Enabled = true;
                        txtSearch.Enabled = false;
                        btnSearch.Enabled = false;
                        ltvProcesses.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select at least one process to be terminated.", "Closure of Processes");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bwkMainWork.WorkerSupportsCancellation == true)
            {
                bwkMainWork.CancelAsync();
            }
        }

        private void bwkMainWork_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker? worker = sender as BackgroundWorker;

            List<ProcessModel>? processes = e.Argument as List<ProcessModel>;

            if (processes != null && processes.Count > 0)
            {
                int processSelected = 0;
                foreach (var item in processes)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        Process.GetProcessById(item.Id).Kill();
                    }

                    processSelected++;

                    worker.ReportProgress(processSelected / processes.Count * 100);
                }
            }
        }

        private void bwkMainWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                this.progressBar1.Value = e.ProgressPercentage;
                tsLStatus.Text = $"Processing {e.ProgressPercentage}%...";
            }));
        }

        private void bwkMainWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                tsLStatus.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                tsLStatus.Text = "Error: " + e.Error.Message;
                MessageBox.Show($"An error occurred while closing processes.\n\nDetalhes: {e.Error.Message}.", "Closure of Processes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tsLStatus.Text = "Done!";
            }

            this.progressBar1.Value = 0;

            btnEndProcess.Enabled = false;
            btnCancel.Enabled = false;
            txtSearch.Enabled = true;
            btnSearch.Enabled = true;
            ltvProcesses.Enabled = true;

            btnSearch.Invoke(new Action(() =>
            {
                Thread.Sleep(1000);
                btnSearch.PerformClick();
            }));
        }
    }
}
