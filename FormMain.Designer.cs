namespace MovieHelper
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools_Mouse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools_Registry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_TimesClicked = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.tpTime = new MovieHelper.TimePicker();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.context.SuspendLayout();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Something want?";
            this.notifyIcon.ContextMenuStrip = this.context;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Movie Helper is still running...";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextOpen,
            this.contextClose});
            this.context.Name = "contextMenuStrip";
            this.context.Size = new System.Drawing.Size(104, 48);
            // 
            // contextOpen
            // 
            this.contextOpen.Name = "contextOpen";
            this.contextOpen.Size = new System.Drawing.Size(103, 22);
            this.contextOpen.Text = "Open";
            this.contextOpen.Click += new System.EventHandler(this.contextOpen_Click);
            // 
            // contextClose
            // 
            this.contextClose.Image = ((System.Drawing.Image)(resources.GetObject("contextClose.Image")));
            this.contextClose.Name = "contextClose";
            this.contextClose.Size = new System.Drawing.Size(103, 22);
            this.contextClose.Text = "Close";
            this.contextClose.Click += new System.EventHandler(this.contextClose_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 100000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTools,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(225, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile_Exit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFile_Exit
            // 
            this.menuFile_Exit.Name = "menuFile_Exit";
            this.menuFile_Exit.Size = new System.Drawing.Size(93, 22);
            this.menuFile_Exit.Text = "E&xit";
            this.menuFile_Exit.Click += new System.EventHandler(this.menuFile_Exit_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTools_Mouse,
            this.menuTools_Registry});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(46, 20);
            this.menuTools.Text = "&Tools";
            // 
            // menuTools_Mouse
            // 
            this.menuTools_Mouse.Name = "menuTools_Mouse";
            this.menuTools_Mouse.Size = new System.Drawing.Size(180, 22);
            this.menuTools_Mouse.Text = "&Mouse";
            this.menuTools_Mouse.Click += new System.EventHandler(this.menuTools_Mouse_Click);
            // 
            // menuTools_Registry
            // 
            this.menuTools_Registry.Enabled = false;
            this.menuTools_Registry.Name = "menuTools_Registry";
            this.menuTools_Registry.Size = new System.Drawing.Size(180, 22);
            this.menuTools_Registry.Text = "&Registry";
            this.menuTools_Registry.Click += new System.EventHandler(this.menuTools_Registry_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp_About});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelp_About
            // 
            this.menuHelp_About.Name = "menuHelp_About";
            this.menuHelp_About.Size = new System.Drawing.Size(116, 22);
            this.menuHelp_About.Text = "&About...";
            this.menuHelp_About.Click += new System.EventHandler(this.menuHelp_About_Click_1);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus_Info,
            this.toolStripStatusLabel1,
            this.lblStatus_TimesClicked});
            this.status.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.status.Location = new System.Drawing.Point(0, 87);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(225, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 3;
            // 
            // lblStatus_Info
            // 
            this.lblStatus_Info.Name = "lblStatus_Info";
            this.lblStatus_Info.Size = new System.Drawing.Size(34, 17);
            this.lblStatus_Info.Text = "INFO";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblStatus_TimesClicked
            // 
            this.lblStatus_TimesClicked.Name = "lblStatus_TimesClicked";
            this.lblStatus_TimesClicked.Size = new System.Drawing.Size(92, 17);
            this.lblStatus_TimesClicked.Text = "0 Times Clicked.";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.tpTime);
            this.gbTime.Controls.Add(this.btnSetTime);
            this.gbTime.Location = new System.Drawing.Point(4, 23);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(214, 51);
            this.gbTime.TabIndex = 7;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // tpTime
            // 
            this.tpTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpTime.Location = new System.Drawing.Point(6, 13);
            this.tpTime.Name = "tpTime";
            this.tpTime.Size = new System.Drawing.Size(120, 29);
            this.tpTime.TabIndex = 7;
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(132, 19);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 6;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 109);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.gbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Helper";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormClient_SizeChanged);
            this.context.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem contextClose;
        private System.Windows.Forms.ToolStripMenuItem contextOpen;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Button btnSetTime;
        private TimePicker tpTime;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuTools_Mouse;
        private System.Windows.Forms.ToolStripMenuItem menuTools_Registry;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelp_About;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_Info;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_TimesClicked;
    }
}

