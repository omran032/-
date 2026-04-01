namespace tracker
{
    partial class FormTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimer));
            this.ElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_btnShow = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_btnHide = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSHide005 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_01 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_02 = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_StopTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_StartTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_RestartBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_RestartWork = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimerBreak = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.BorderRadius = 15;
            this.ElipseForm.TargetControl = this;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ContextMenuStrip = this.CMS;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblTime.Location = new System.Drawing.Point(69, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 22);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.lblTime, "مؤقت الوقت الذي تم فتح برامج العمل");
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_btnShow,
            this.CMS_btnHide,
            this.CMS_StopTimer,
            this.CMS_StartTimer,
            this.restartToolStripMenuItem,
            this.CMS_Close,
            this.CMS_Settings});
            this.CMS.Name = "contextMenuStrip1";
            this.CMS.Size = new System.Drawing.Size(133, 158);
            // 
            // CMS_btnShow
            // 
            this.CMS_btnShow.Name = "CMS_btnShow";
            this.CMS_btnShow.Size = new System.Drawing.Size(132, 22);
            this.CMS_btnShow.Text = "Show";
            this.CMS_btnShow.Click += new System.EventHandler(this.CMS_btnShow_Click);
            // 
            // CMS_btnHide
            // 
            this.CMS_btnHide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSHide005,
            this.CMS_01,
            this.CMS_02});
            this.CMS_btnHide.Name = "CMS_btnHide";
            this.CMS_btnHide.Size = new System.Drawing.Size(132, 22);
            this.CMS_btnHide.Text = "Hide";
            this.CMS_btnHide.Click += new System.EventHandler(this.CMS_btnHide_Click);
            // 
            // CMSHide005
            // 
            this.CMSHide005.Name = "CMSHide005";
            this.CMSHide005.Size = new System.Drawing.Size(95, 22);
            this.CMSHide005.Text = "0.05";
            this.CMSHide005.Click += new System.EventHandler(this.CMSHide005_Click);
            // 
            // CMS_01
            // 
            this.CMS_01.Name = "CMS_01";
            this.CMS_01.Size = new System.Drawing.Size(95, 22);
            this.CMS_01.Text = "0.1";
            this.CMS_01.Click += new System.EventHandler(this.CMS_01_Click);
            // 
            // CMS_02
            // 
            this.CMS_02.Name = "CMS_02";
            this.CMS_02.Size = new System.Drawing.Size(95, 22);
            this.CMS_02.Text = "0.2";
            this.CMS_02.Click += new System.EventHandler(this.CMS_02_Click);
            // 
            // CMS_StopTimer
            // 
            this.CMS_StopTimer.Name = "CMS_StopTimer";
            this.CMS_StopTimer.Size = new System.Drawing.Size(132, 22);
            this.CMS_StopTimer.Text = "Stop Timer";
            this.CMS_StopTimer.Click += new System.EventHandler(this.CMS_StopTimer_Click);
            // 
            // CMS_StartTimer
            // 
            this.CMS_StartTimer.Name = "CMS_StartTimer";
            this.CMS_StartTimer.Size = new System.Drawing.Size(132, 22);
            this.CMS_StartTimer.Text = "Start Timer";
            this.CMS_StartTimer.Click += new System.EventHandler(this.CMS_StartTimer_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_RestartBreak,
            this.CMS_RestartWork});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // CMS_RestartBreak
            // 
            this.CMS_RestartBreak.Name = "CMS_RestartBreak";
            this.CMS_RestartBreak.Size = new System.Drawing.Size(142, 22);
            this.CMS_RestartBreak.Text = "Restart Break";
            this.CMS_RestartBreak.Click += new System.EventHandler(this.CMS_RestartBreak_Click);
            // 
            // CMS_RestartWork
            // 
            this.CMS_RestartWork.Name = "CMS_RestartWork";
            this.CMS_RestartWork.Size = new System.Drawing.Size(142, 22);
            this.CMS_RestartWork.Text = "Restak Work";
            this.CMS_RestartWork.Click += new System.EventHandler(this.CMS_RestartWork_Click);
            // 
            // CMS_Close
            // 
            this.CMS_Close.Name = "CMS_Close";
            this.CMS_Close.Size = new System.Drawing.Size(132, 22);
            this.CMS_Close.Text = "Close";
            this.CMS_Close.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // CMS_Settings
            // 
            this.CMS_Settings.Name = "CMS_Settings";
            this.CMS_Settings.Size = new System.Drawing.Size(132, 22);
            this.CMS_Settings.Text = "Settings";
            this.CMS_Settings.Click += new System.EventHandler(this.CMS_Settings_Click);
            // 
            // lblTimerBreak
            // 
            this.lblTimerBreak.AutoSize = true;
            this.lblTimerBreak.ContextMenuStrip = this.CMS;
            this.lblTimerBreak.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblTimerBreak.Location = new System.Drawing.Point(232, 21);
            this.lblTimerBreak.Name = "lblTimerBreak";
            this.lblTimerBreak.Size = new System.Drawing.Size(80, 22);
            this.lblTimerBreak.TabIndex = 3;
            this.lblTimerBreak.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.lblTimerBreak, "مؤقت الوقت الذي لم تقم بفتح برامج العمل");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ContextMenuStrip = this.CMS;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(175, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "مؤقت الوقت الذي لم تقم بفتح برامج العمل");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.CMS;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "مؤقت الوقت الذي تم فتح برامج العمل");
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 65);
            this.ContextMenuStrip = this.CMS;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTimerBreak);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormTimer";
            this.Text = "Timer Tracker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse ElipseForm;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimerBreak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem CMS_btnShow;
        private System.Windows.Forms.ToolStripMenuItem CMS_btnHide;
        private System.Windows.Forms.ToolStripMenuItem CMSHide005;
        private System.Windows.Forms.ToolStripMenuItem CMS_01;
        private System.Windows.Forms.ToolStripMenuItem CMS_02;
        private System.Windows.Forms.ToolStripMenuItem CMS_StopTimer;
        private System.Windows.Forms.ToolStripMenuItem CMS_StartTimer;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMS_RestartBreak;
        private System.Windows.Forms.ToolStripMenuItem CMS_RestartWork;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem CMS_Close;
        private System.Windows.Forms.ToolStripMenuItem CMS_Settings;
    }
}

