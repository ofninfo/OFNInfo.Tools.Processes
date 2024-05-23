namespace OFNInfo.Tools.Processes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ltvProcesses = new ListView();
            progressBar1 = new ProgressBar();
            btnEndProcess = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            bwkMainWork = new System.ComponentModel.BackgroundWorker();
            stsMain = new StatusStrip();
            tsLStatus = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            stsMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            tableLayoutPanel1.SetColumnSpan(txtSearch, 3);
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(12, 35);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(800, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(txtSearch, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(ltvProcesses, 1, 4);
            tableLayoutPanel1.Controls.Add(progressBar1, 1, 6);
            tableLayoutPanel1.Controls.Add(btnEndProcess, 3, 8);
            tableLayoutPanel1.Controls.Add(btnCancel, 5, 8);
            tableLayoutPanel1.Controls.Add(btnSearch, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(934, 526);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(688, 15);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // ltvProcesses
            // 
            ltvProcesses.AllowColumnReorder = true;
            tableLayoutPanel1.SetColumnSpan(ltvProcesses, 5);
            ltvProcesses.Dock = DockStyle.Fill;
            ltvProcesses.FullRowSelect = true;
            ltvProcesses.Location = new Point(13, 69);
            ltvProcesses.Name = "ltvProcesses";
            ltvProcesses.Size = new Size(908, 339);
            ltvProcesses.Sorting = SortOrder.Ascending;
            ltvProcesses.TabIndex = 2;
            ltvProcesses.UseCompatibleStateImageBehavior = false;
            ltvProcesses.View = View.Details;
            ltvProcesses.ColumnClick += ltvProcesses_ColumnClick;
            // 
            // progressBar1
            // 
            tableLayoutPanel1.SetColumnSpan(progressBar1, 5);
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(13, 424);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(908, 17);
            progressBar1.TabIndex = 5;
            // 
            // btnEndProcess
            // 
            btnEndProcess.Dock = DockStyle.Fill;
            btnEndProcess.Enabled = false;
            btnEndProcess.Location = new Point(717, 457);
            btnEndProcess.Name = "btnEndProcess";
            btnEndProcess.Size = new Size(94, 36);
            btnEndProcess.TabIndex = 6;
            btnEndProcess.Text = "End Process";
            btnEndProcess.UseVisualStyleBackColor = true;
            btnEndProcess.Click += btnEndProcess_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(827, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(827, 13);
            btnSearch.Name = "btnSearch";
            tableLayoutPanel1.SetRowSpan(btnSearch, 2);
            btnSearch.Size = new Size(94, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // bwkMainWork
            // 
            bwkMainWork.WorkerReportsProgress = true;
            bwkMainWork.WorkerSupportsCancellation = true;
            bwkMainWork.DoWork += bwkMainWork_DoWork;
            bwkMainWork.ProgressChanged += bwkMainWork_ProgressChanged;
            bwkMainWork.RunWorkerCompleted += bwkMainWork_RunWorkerCompleted;
            // 
            // stsMain
            // 
            stsMain.Items.AddRange(new ToolStripItem[] { tsLStatus });
            stsMain.Location = new Point(0, 504);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(934, 22);
            stsMain.TabIndex = 5;
            stsMain.Text = "statusStrip1";
            // 
            // tsLStatus
            // 
            tsLStatus.Name = "tsLStatus";
            tsLStatus.Size = new Size(35, 17);
            tsLStatus.Text = "Done";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 526);
            Controls.Add(stsMain);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Closure of Processes";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListView ltvProcesses;
        private System.ComponentModel.BackgroundWorker bwkMainWork;
        private ProgressBar progressBar1;
        private Button btnEndProcess;
        private Button btnCancel;
        private Button btnSearch;
        private StatusStrip stsMain;
        private ToolStripStatusLabel tsLStatus;
    }
}