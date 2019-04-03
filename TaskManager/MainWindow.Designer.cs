namespace TaskManager
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroProgressSpinner4 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.label2 = new System.Windows.Forms.Label();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusProcesses = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvcxtmnu = new System.Windows.Forms.ContextMenu();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(17, 95);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(828, 550);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(828, 550);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(820, 508);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Overview";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 508);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(597, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPU";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(197, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "+";
            // 
            // metroProgressSpinner4
            // 
            this.metroProgressSpinner4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner4.Location = new System.Drawing.Point(517, 280);
            this.metroProgressSpinner4.Maximum = 100;
            this.metroProgressSpinner4.Name = "metroProgressSpinner4";
            this.metroProgressSpinner4.Size = new System.Drawing.Size(195, 175);
            this.metroProgressSpinner4.Spinning = false;
            this.metroProgressSpinner4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner4.TabIndex = 5;
            this.metroProgressSpinner4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner4.UseSelectable = true;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner3.Location = new System.Drawing.Point(107, 280);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(195, 175);
            this.metroProgressSpinner3.Spinning = false;
            this.metroProgressSpinner3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner3.TabIndex = 4;
            this.metroProgressSpinner3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner3.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(586, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory";
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(517, 39);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(195, 175);
            this.metroProgressSpinner2.Spinning = false;
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner2.TabIndex = 1;
            this.metroProgressSpinner2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner2.UseSelectable = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(107, 39);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(195, 175);
            this.metroProgressSpinner1.Spinning = false;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(187, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage2.Controls.Add(this.metroListView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(820, 508);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Processes";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.Black;
            this.metroListView1.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.metroListView1.ContextMenu = this.lvcxtmnu;
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Margin = new System.Windows.Forms.Padding(0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(820, 508);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroListView1.TabIndex = 2;
            this.metroListView1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.UseStyleColors = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start Time";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPU Time";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory Usage";
            this.columnHeader5.Width = 182;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Peak Memory Usage";
            this.columnHeader6.Width = 243;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No. of Handles";
            this.columnHeader7.Width = 199;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No. of Threads";
            this.columnHeader8.Width = 187;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage3.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 8;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(820, 508);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Performance";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 8;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 8;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(820, 510);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 8;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 8;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(820, 510);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "metroTabPage5";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 8;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProcesses,
            this.statusThreads});
            this.statusStrip.Location = new System.Drawing.Point(17, 645);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(828, 25);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusProcesses
            // 
            this.statusProcesses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.statusProcesses.Name = "statusProcesses";
            this.statusProcesses.Size = new System.Drawing.Size(72, 20);
            this.statusProcesses.Text = "Processes";
            // 
            // statusThreads
            // 
            this.statusThreads.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.statusThreads.Name = "statusThreads";
            this.statusThreads.Size = new System.Drawing.Size(61, 20);
            this.statusThreads.Text = "Threads";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menuStrip1.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(17, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.endProcessToolStripMenuItem,
            this.eXitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runToolStripMenuItem.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.runToolStripMenuItem.Text = "Run new task";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // endProcessToolStripMenuItem
            // 
            this.endProcessToolStripMenuItem.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.endProcessToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.endProcessToolStripMenuItem.Name = "endProcessToolStripMenuItem";
            this.endProcessToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.endProcessToolStripMenuItem.Text = "End Process";
            this.endProcessToolStripMenuItem.Click += new System.EventHandler(this.endProcessToolStripMenuItem_Click);
            // 
            // eXitToolStripMenuItem
            // 
            this.eXitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eXitToolStripMenuItem.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.eXitToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
            this.eXitToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.eXitToolStripMenuItem.Text = "Exit";
            this.eXitToolStripMenuItem.Click += new System.EventHandler(this.eXitToolStripMenuItem_Click);
            // 
            // lvcxtmnu
            // 
            this.lvcxtmnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10});
            this.lvcxtmnu.Popup += new System.EventHandler(this.lvcxtmnu_Popup);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "End Process";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem15,
            this.menuItem16,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14});
            this.menuItem10.Text = "Set Priority";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.RadioCheck = true;
            this.menuItem11.Text = "High";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.RadioCheck = true;
            this.menuItem15.Text = "Above Normal";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.RadioCheck = true;
            this.menuItem16.Text = "Below Normal";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.RadioCheck = true;
            this.menuItem12.Text = "Normal";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 4;
            this.menuItem13.RadioCheck = true;
            this.menuItem13.Text = "Low";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 5;
            this.menuItem14.RadioCheck = true;
            this.menuItem14.Text = "Real Time";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 687);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(17, 67, 17, 17);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "TaskManager";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusProcesses;
        private System.Windows.Forms.ToolStripStatusLabel statusThreads;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endProcessToolStripMenuItem;
        private System.Windows.Forms.ContextMenu lvcxtmnu;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
    }
}