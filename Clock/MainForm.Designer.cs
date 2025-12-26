namespace Clock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(96, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(339, 64);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiShowConsole,
            this.toolStripSeparator3,
            this.tsmiFont,
            this.tsmiColor,
            this.tsmiAlarms,
            this.toolStripSeparator4,
            this.tsmiAutoStart,
            this.toolStripSeparator5,
            this.tsmiQuit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(203, 354);
            // 
            // tsmiTopmost
            // 
            this.tsmiTopmost.CheckOnClick = true;
            this.tsmiTopmost.Name = "tsmiTopmost";
            this.tsmiTopmost.Size = new System.Drawing.Size(202, 32);
            this.tsmiTopmost.Text = "Topmost";
            this.tsmiTopmost.Click += new System.EventHandler(this.tsmiTopmost_Click);
            // 
            // tsmiShowControls
            // 
            this.tsmiShowControls.CheckOnClick = true;
            this.tsmiShowControls.Name = "tsmiShowControls";
            this.tsmiShowControls.Size = new System.Drawing.Size(202, 32);
            this.tsmiShowControls.Text = "Show controls";
            this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiShowDate
            // 
            this.tsmiShowDate.CheckOnClick = true;
            this.tsmiShowDate.Name = "tsmiShowDate";
            this.tsmiShowDate.Size = new System.Drawing.Size(202, 32);
            this.tsmiShowDate.Text = "Show date";
            this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
            // 
            // tsmiShowWeekday
            // 
            this.tsmiShowWeekday.CheckOnClick = true;
            this.tsmiShowWeekday.Name = "tsmiShowWeekday";
            this.tsmiShowWeekday.Size = new System.Drawing.Size(202, 32);
            this.tsmiShowWeekday.Text = "Show weekday";
            this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiShowConsole
            // 
            this.tsmiShowConsole.CheckOnClick = true;
            this.tsmiShowConsole.Name = "tsmiShowConsole";
            this.tsmiShowConsole.Size = new System.Drawing.Size(202, 32);
            this.tsmiShowConsole.Text = "Show console";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(202, 32);
            this.tsmiFont.Text = "Font";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(202, 32);
            this.tsmiColor.Text = "Color";
            // 
            // tsmiForegroundColor
            // 
            this.tsmiForegroundColor.Name = "tsmiForegroundColor";
            this.tsmiForegroundColor.Size = new System.Drawing.Size(253, 34);
            this.tsmiForegroundColor.Text = "Foreground color";
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(253, 34);
            this.tsmiBackgroundColor.Text = "BackgroundColor";
            // 
            // tsmiAlarms
            // 
            this.tsmiAlarms.Name = "tsmiAlarms";
            this.tsmiAlarms.Size = new System.Drawing.Size(202, 32);
            this.tsmiAlarms.Text = "Alarms";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiAutoStart
            // 
            this.tsmiAutoStart.CheckOnClick = true;
            this.tsmiAutoStart.Name = "tsmiAutoStart";
            this.tsmiAutoStart.Size = new System.Drawing.Size(202, 32);
            this.tsmiAutoStart.Text = "Auto start";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(202, 32);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowDate.Location = new System.Drawing.Point(134, 338);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(200, 34);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Datum tonen";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // cbShowWeekDay
            // 
            this.cbShowWeekDay.AutoSize = true;
            this.cbShowWeekDay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowWeekDay.Location = new System.Drawing.Point(121, 378);
            this.cbShowWeekDay.Name = "cbShowWeekDay";
            this.cbShowWeekDay.Size = new System.Drawing.Size(234, 34);
            this.cbShowWeekDay.TabIndex = 2;
            this.cbShowWeekDay.Text = "Weekdag tonen";
            this.cbShowWeekDay.UseVisualStyleBackColor = true;
            this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.cbShowWeekDay_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideControls.Location = new System.Drawing.Point(134, 275);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(207, 38);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls\r\n";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "System  Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 418);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clock PV_521";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
    }
}

