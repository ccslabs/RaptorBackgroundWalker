namespace RaptorBackground
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fctbConOut = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.niFrmMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotificationIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.displayWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.provideFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.privacyStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRaptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fctbConOut)).BeginInit();
            this.cmsNotificationIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // fctbConOut
            // 
            this.fctbConOut.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbConOut.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbConOut.BackBrush = null;
            this.fctbConOut.BackColor = global::RaptorBackground.Properties.Settings.Default.fctbBackgroundColour;
            this.fctbConOut.CaretVisible = false;
            this.fctbConOut.CharHeight = 14;
            this.fctbConOut.CharWidth = 8;
            this.fctbConOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbConOut.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fctbConOut.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "fctbBackgroundColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fctbConOut.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbConOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fctbConOut.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbConOut.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.fctbConOut.IsReplaceMode = false;
            this.fctbConOut.Location = new System.Drawing.Point(0, 206);
            this.fctbConOut.Name = "fctbConOut";
            this.fctbConOut.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbConOut.ReadOnly = true;
            this.fctbConOut.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbConOut.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbConOut.ServiceColors")));
            this.fctbConOut.ShowLineNumbers = false;
            this.fctbConOut.ShowScrollBars = false;
            this.fctbConOut.Size = new System.Drawing.Size(543, 112);
            this.fctbConOut.TabIndex = 0;
            this.fctbConOut.Zoom = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uris Found:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uris Processed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agent\'s Rank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computer Crime Service Agent\'s License Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "COs Processed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = " COs Found:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "COs Awaiting Processing:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Current Uri:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label9.Location = new System.Drawing.Point(160, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label10.Location = new System.Drawing.Point(160, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label11.Location = new System.Drawing.Point(160, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label12.Location = new System.Drawing.Point(160, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label13.Location = new System.Drawing.Point(297, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label14.Location = new System.Drawing.Point(104, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label15.Location = new System.Drawing.Point(160, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label16.Location = new System.Drawing.Point(160, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "...";
            // 
            // niFrmMain
            // 
            this.niFrmMain.ContextMenuStrip = this.cmsNotificationIcon;
            this.niFrmMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niFrmMain.Icon")));
            this.niFrmMain.Text = "notifyIcon1";
            this.niFrmMain.Visible = true;
            // 
            // cmsNotificationIcon
            // 
            this.cmsNotificationIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.displayWindowToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator6,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.cmsNotificationIcon.Name = "cmsNotificationIcon";
            this.cmsNotificationIcon.Size = new System.Drawing.Size(160, 154);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.toolStripSeparator3,
            this.logOffToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteAccountToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem1.Text = "Account";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.group_add;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.group_key;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Enabled = false;
            this.logOffToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.group_error;
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Enabled = false;
            this.deleteAccountToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.group_delete;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // displayWindowToolStripMenuItem
            // 
            this.displayWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripMenuItem,
            this.coloursToolStripMenuItem});
            this.displayWindowToolStripMenuItem.Name = "displayWindowToolStripMenuItem";
            this.displayWindowToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.displayWindowToolStripMenuItem.Text = "Display Window";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.monitor_go;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.Enabled = false;
            this.coloursToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.color_swatch;
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coloursToolStripMenuItem.Text = "Colours";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Image = global::RaptorBackground.Properties.Resources.application_view_gallery;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem2.Text = "Raptor Manager";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator7,
            this.provideFeedbackToolStripMenuItem,
            this.toolStripSeparator8,
            this.privacyStatementToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripSeparator9,
            this.donateToolStripMenuItem,
            this.toolStripSeparator10,
            this.aboutRaptorToolStripMenuItem});
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.help;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(166, 6);
            // 
            // provideFeedbackToolStripMenuItem
            // 
            this.provideFeedbackToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.report;
            this.provideFeedbackToolStripMenuItem.Name = "provideFeedbackToolStripMenuItem";
            this.provideFeedbackToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.provideFeedbackToolStripMenuItem.Text = "Provide Feedback";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(166, 6);
            // 
            // privacyStatementToolStripMenuItem
            // 
            this.privacyStatementToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.page_white_link;
            this.privacyStatementToolStripMenuItem.Name = "privacyStatementToolStripMenuItem";
            this.privacyStatementToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.privacyStatementToolStripMenuItem.Text = "Privacy Statement";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::RaptorBackground.Properties.Resources.application_home;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem4.Text = "Open Website";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(166, 6);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.money;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(166, 6);
            // 
            // aboutRaptorToolStripMenuItem
            // 
            this.aboutRaptorToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.information;
            this.aboutRaptorToolStripMenuItem.Name = "aboutRaptorToolStripMenuItem";
            this.aboutRaptorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutRaptorToolStripMenuItem.Text = "About Raptor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::RaptorBackground.Properties.Resources.cancel;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerSecond
            // 
            this.timerSecond.Enabled = true;
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "fctbConOutForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = global::RaptorBackground.Properties.Settings.Default.fctbConOutForeColour;
            this.label17.Location = new System.Drawing.Point(422, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 16);
            this.label17.TabIndex = 19;
            this.label17.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(297, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Agent\'s Jurisdiction:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblAllowedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblAllowedForeColour;
            this.label19.Location = new System.Drawing.Point(297, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(271, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "A:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblRestrictedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblRestrictedForeColour;
            this.label21.Location = new System.Drawing.Point(377, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 16);
            this.label21.TabIndex = 23;
            this.label21.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(352, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 16);
            this.label22.TabIndex = 22;
            this.label22.Text = "R:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblCriminalForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label23.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblCriminalForeColour;
            this.label23.Location = new System.Drawing.Point(458, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 16);
            this.label23.TabIndex = 25;
            this.label23.Text = "...";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(432, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 16);
            this.label24.TabIndex = 24;
            this.label24.Text = "C:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblCriminalForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label25.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblCriminalForeColour;
            this.label25.Location = new System.Drawing.Point(458, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 16);
            this.label25.TabIndex = 31;
            this.label25.Text = "...";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(433, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 16);
            this.label26.TabIndex = 30;
            this.label26.Text = "C:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblRestrictedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label27.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblRestrictedForeColour;
            this.label27.Location = new System.Drawing.Point(377, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 16);
            this.label27.TabIndex = 29;
            this.label27.Text = "...";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(352, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 16);
            this.label28.TabIndex = 28;
            this.label28.Text = "R:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblAllowedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label29.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblAllowedForeColour;
            this.label29.Location = new System.Drawing.Point(297, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 16);
            this.label29.TabIndex = 27;
            this.label29.Text = "...";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(271, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 16);
            this.label30.TabIndex = 26;
            this.label30.Text = "A:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblCriminalForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label31.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblCriminalForeColour;
            this.label31.Location = new System.Drawing.Point(458, 105);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 16);
            this.label31.TabIndex = 37;
            this.label31.Text = "...";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(433, 105);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 16);
            this.label32.TabIndex = 36;
            this.label32.Text = "C:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblRestrictedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label33.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblRestrictedForeColour;
            this.label33.Location = new System.Drawing.Point(377, 105);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(20, 16);
            this.label33.TabIndex = 35;
            this.label33.Text = "...";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(352, 105);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 16);
            this.label34.TabIndex = 34;
            this.label34.Text = "R:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "lblAllowedForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label35.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = global::RaptorBackground.Properties.Settings.Default.lblAllowedForeColour;
            this.label35.Location = new System.Drawing.Point(297, 105);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 16);
            this.label35.TabIndex = 33;
            this.label35.Text = "...";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(271, 105);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 16);
            this.label36.TabIndex = 32;
            this.label36.Text = "A:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RaptorBackground.Properties.Settings.Default.frmMainBackColour;
            this.ClientSize = new System.Drawing.Size(543, 318);
            this.ControlBox = global::RaptorBackground.Properties.Settings.Default.frmMainControlBox;
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fctbConOut);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TransparencyKey", global::RaptorBackground.Properties.Settings.Default, "frmMainTransparencyKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "frmMainBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ControlBox", global::RaptorBackground.Properties.Settings.Default, "frmMainControlBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "frmMainForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::RaptorBackground.Properties.Settings.Default, "frmMainLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::RaptorBackground.Properties.Settings.Default.frmMainForeColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::RaptorBackground.Properties.Settings.Default.frmMainLocation;
            this.Name = "frmMain";
            this.Opacity = 0.25D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raptor Background";
            this.TransparencyKey = global::RaptorBackground.Properties.Settings.Default.frmMainTransparencyKey;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Move += new System.EventHandler(this.frmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.fctbConOut)).EndInit();
            this.cmsNotificationIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctbConOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NotifyIcon niFrmMain;
        private System.Windows.Forms.ContextMenuStrip cmsNotificationIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem displayWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem provideFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem privacyStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem aboutRaptorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
    }
}

