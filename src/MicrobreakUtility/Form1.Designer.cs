using Microsoft.Win32;
using System.Windows.Forms;

namespace MicrobreakUtility
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBreakNow = new System.Windows.Forms.Button();
            this.labelTimeUntilNextBreak = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak = new System.Windows.Forms.TextBox();
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak = new System.Windows.Forms.TextBox();
            this.checkBoxPlaySoundAtEndOfBreak = new System.Windows.Forms.CheckBox();
            this.checkBoxPlaySoundAtStartOfBreak = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPostponeBreakBy = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownIntervalBetweenBreaks = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDurationOfBreaks = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelVersionField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelToIcons8 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerMicrobreak = new System.Windows.Forms.Timer(this.components);
            this.checkBoxResetBreakOnWorkstationUnlock = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostponeBreakBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalBetweenBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationOfBreaks)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.buttonReset);
            this.tabPageHome.Controls.Add(this.buttonBreakNow);
            this.tabPageHome.Controls.Add(this.labelTimeUntilNextBreak);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(273, 275);
            this.tabPageHome.TabIndex = 2;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Image = global::MicrobreakUtility.Properties.Resources.Synchronize;
            this.buttonReset.Location = new System.Drawing.Point(102, 119);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(68, 68);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBreakNow
            // 
            this.buttonBreakNow.BackColor = System.Drawing.Color.White;
            this.buttonBreakNow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBreakNow.FlatAppearance.BorderSize = 0;
            this.buttonBreakNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonBreakNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBreakNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBreakNow.Image = global::MicrobreakUtility.Properties.Resources.HeartHealth;
            this.buttonBreakNow.Location = new System.Drawing.Point(102, 187);
            this.buttonBreakNow.Name = "buttonBreakNow";
            this.buttonBreakNow.Size = new System.Drawing.Size(68, 68);
            this.buttonBreakNow.TabIndex = 7;
            this.buttonBreakNow.UseVisualStyleBackColor = false;
            this.buttonBreakNow.Click += new System.EventHandler(this.buttonBreakNow_Click);
            // 
            // labelTimeUntilNextBreak
            // 
            this.labelTimeUntilNextBreak.AutoSize = true;
            this.labelTimeUntilNextBreak.Font = new System.Drawing.Font("Calibri", 68.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeUntilNextBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTimeUntilNextBreak.Location = new System.Drawing.Point(8, 8);
            this.labelTimeUntilNextBreak.Name = "labelTimeUntilNextBreak";
            this.labelTimeUntilNextBreak.Size = new System.Drawing.Size(256, 111);
            this.labelTimeUntilNextBreak.TabIndex = 6;
            this.labelTimeUntilNextBreak.Text = "00:00";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.AutoScroll = true;
            this.tabPageSettings.Controls.Add(this.checkBoxResetBreakOnWorkstationUnlock);
            this.tabPageSettings.Controls.Add(this.textBoxlocationOfWavFileToPlayAtEndOfBreak);
            this.tabPageSettings.Controls.Add(this.textBoxLocationOfWavFileToPlayAtStartOfBreak);
            this.tabPageSettings.Controls.Add(this.checkBoxPlaySoundAtEndOfBreak);
            this.tabPageSettings.Controls.Add(this.checkBoxPlaySoundAtStartOfBreak);
            this.tabPageSettings.Controls.Add(this.label7);
            this.tabPageSettings.Controls.Add(this.numericUpDownPostponeBreakBy);
            this.tabPageSettings.Controls.Add(this.label8);
            this.tabPageSettings.Controls.Add(this.label5);
            this.tabPageSettings.Controls.Add(this.numericUpDownIntervalBetweenBreaks);
            this.tabPageSettings.Controls.Add(this.label6);
            this.tabPageSettings.Controls.Add(this.label4);
            this.tabPageSettings.Controls.Add(this.numericUpDownDurationOfBreaks);
            this.tabPageSettings.Controls.Add(this.label3);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(273, 275);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // textBoxlocationOfWavFileToPlayAtEndOfBreak
            // 
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.Location = new System.Drawing.Point(43, 219);
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.Name = "textBoxlocationOfWavFileToPlayAtEndOfBreak";
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.Size = new System.Drawing.Size(213, 20);
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.TabIndex = 20;
            this.textBoxlocationOfWavFileToPlayAtEndOfBreak.TextChanged += new System.EventHandler(this.textBoxlocationOfWavFileToPlayAtEndOfBreak_TextChanged);
            // 
            // textBoxLocationOfWavFileToPlayAtStartOfBreak
            // 
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.Location = new System.Drawing.Point(43, 164);
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.Name = "textBoxLocationOfWavFileToPlayAtStartOfBreak";
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.Size = new System.Drawing.Size(213, 20);
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.TabIndex = 19;
            this.textBoxLocationOfWavFileToPlayAtStartOfBreak.TextChanged += new System.EventHandler(this.textBoxLocationOfWavFileToPlayAtStartOfBreak_TextChanged);
            // 
            // checkBoxPlaySoundAtEndOfBreak
            // 
            this.checkBoxPlaySoundAtEndOfBreak.AutoSize = true;
            this.checkBoxPlaySoundAtEndOfBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxPlaySoundAtEndOfBreak.Location = new System.Drawing.Point(23, 196);
            this.checkBoxPlaySoundAtEndOfBreak.Name = "checkBoxPlaySoundAtEndOfBreak";
            this.checkBoxPlaySoundAtEndOfBreak.Size = new System.Drawing.Size(180, 17);
            this.checkBoxPlaySoundAtEndOfBreak.TabIndex = 18;
            this.checkBoxPlaySoundAtEndOfBreak.Text = "Play sound at the end of a break";
            this.checkBoxPlaySoundAtEndOfBreak.UseVisualStyleBackColor = true;
            this.checkBoxPlaySoundAtEndOfBreak.CheckedChanged += new System.EventHandler(this.checkBoxPlaySoundAtEndOfBreak_CheckedChanged);
            // 
            // checkBoxPlaySoundAtStartOfBreak
            // 
            this.checkBoxPlaySoundAtStartOfBreak.AutoSize = true;
            this.checkBoxPlaySoundAtStartOfBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxPlaySoundAtStartOfBreak.Location = new System.Drawing.Point(23, 141);
            this.checkBoxPlaySoundAtStartOfBreak.Name = "checkBoxPlaySoundAtStartOfBreak";
            this.checkBoxPlaySoundAtStartOfBreak.Size = new System.Drawing.Size(208, 17);
            this.checkBoxPlaySoundAtStartOfBreak.TabIndex = 17;
            this.checkBoxPlaySoundAtStartOfBreak.Text = "Play sound at the beginning of a break";
            this.checkBoxPlaySoundAtStartOfBreak.UseVisualStyleBackColor = true;
            this.checkBoxPlaySoundAtStartOfBreak.CheckedChanged += new System.EventHandler(this.checkBoxPlaySoundAtStartOfBreak_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(222, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "mins.";
            // 
            // numericUpDownPostponeBreakBy
            // 
            this.numericUpDownPostponeBreakBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDownPostponeBreakBy.Location = new System.Drawing.Point(150, 80);
            this.numericUpDownPostponeBreakBy.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numericUpDownPostponeBreakBy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPostponeBreakBy.Name = "numericUpDownPostponeBreakBy";
            this.numericUpDownPostponeBreakBy.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownPostponeBreakBy.TabIndex = 15;
            this.numericUpDownPostponeBreakBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPostponeBreakBy.ValueChanged += new System.EventHandler(this.numericUpDownPostponeBreakBy_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(20, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postpone breaks by:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(222, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "mins.";
            // 
            // numericUpDownIntervalBetweenBreaks
            // 
            this.numericUpDownIntervalBetweenBreaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDownIntervalBetweenBreaks.Location = new System.Drawing.Point(150, 48);
            this.numericUpDownIntervalBetweenBreaks.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numericUpDownIntervalBetweenBreaks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalBetweenBreaks.Name = "numericUpDownIntervalBetweenBreaks";
            this.numericUpDownIntervalBetweenBreaks.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownIntervalBetweenBreaks.TabIndex = 12;
            this.numericUpDownIntervalBetweenBreaks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalBetweenBreaks.ValueChanged += new System.EventHandler(this.numericUpDownIntervalBetweenBreaks_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(20, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Interval between breaks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(222, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "mins.";
            // 
            // numericUpDownDurationOfBreaks
            // 
            this.numericUpDownDurationOfBreaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDownDurationOfBreaks.Location = new System.Drawing.Point(150, 16);
            this.numericUpDownDurationOfBreaks.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numericUpDownDurationOfBreaks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDurationOfBreaks.Name = "numericUpDownDurationOfBreaks";
            this.numericUpDownDurationOfBreaks.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownDurationOfBreaks.TabIndex = 9;
            this.numericUpDownDurationOfBreaks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDurationOfBreaks.ValueChanged += new System.EventHandler(this.numericUpDownDurationOfBreaks_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duration of breaks:";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelVersionField);
            this.tabPageAbout.Controls.Add(this.label2);
            this.tabPageAbout.Controls.Add(this.linkLabelToIcons8);
            this.tabPageAbout.Controls.Add(this.label1);
            this.tabPageAbout.Controls.Add(this.pictureBox2);
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(273, 275);
            this.tabPageAbout.TabIndex = 1;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelVersionField
            // 
            this.labelVersionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelVersionField.Location = new System.Drawing.Point(54, 214);
            this.labelVersionField.Name = "labelVersionField";
            this.labelVersionField.Size = new System.Drawing.Size(164, 25);
            this.labelVersionField.TabIndex = 6;
            this.labelVersionField.Text = "v.X";
            this.labelVersionField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(52, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "software version";
            // 
            // linkLabelToIcons8
            // 
            this.linkLabelToIcons8.AutoSize = true;
            this.linkLabelToIcons8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelToIcons8.Location = new System.Drawing.Point(99, 98);
            this.linkLabelToIcons8.Name = "linkLabelToIcons8";
            this.linkLabelToIcons8.Size = new System.Drawing.Size(75, 25);
            this.linkLabelToIcons8.TabIndex = 1;
            this.linkLabelToIcons8.TabStop = true;
            this.linkLabelToIcons8.Text = "Icons8";
            this.linkLabelToIcons8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelToIcons8_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "icons courtesy of";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MicrobreakUtility.Properties.Resources.HeartHealth;
            this.pictureBox2.Location = new System.Drawing.Point(112, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MicrobreakUtility.Properties.Resources.Icons8Logo;
            this.pictureBox1.Location = new System.Drawing.Point(111, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Microbreak Utility";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timerMicrobreak
            // 
            this.timerMicrobreak.Tick += new System.EventHandler(this.timerMicrobreak_Tick);
            // 
            // checkBoxResetBreakOnWorkstationUnlock
            // 
            this.checkBoxResetBreakOnWorkstationUnlock.AutoSize = true;
            this.checkBoxResetBreakOnWorkstationUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxResetBreakOnWorkstationUnlock.Location = new System.Drawing.Point(23, 112);
            this.checkBoxResetBreakOnWorkstationUnlock.Name = "checkBoxResetBreakOnWorkstationUnlock";
            this.checkBoxResetBreakOnWorkstationUnlock.Size = new System.Drawing.Size(191, 17);
            this.checkBoxResetBreakOnWorkstationUnlock.TabIndex = 21;
            this.checkBoxResetBreakOnWorkstationUnlock.Text = "Reset break on workstation unlock";
            this.checkBoxResetBreakOnWorkstationUnlock.UseVisualStyleBackColor = true;
            this.checkBoxResetBreakOnWorkstationUnlock.CheckedChanged += new System.EventHandler(this.checkBoxResetBreakOnWorkstationUnlock_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 298);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micrbreak Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostponeBreakBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalBetweenBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationOfBreaks)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelToIcons8;
        private System.Windows.Forms.Label labelVersionField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDurationOfBreaks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalBetweenBreaks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownPostponeBreakBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.Button buttonBreakNow;
        private System.Windows.Forms.Label labelTimeUntilNextBreak;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Button buttonReset;
        private CheckBox checkBoxPlaySoundAtStartOfBreak;
        private CheckBox checkBoxPlaySoundAtEndOfBreak;
        private TextBox textBoxLocationOfWavFileToPlayAtStartOfBreak;
        private TextBox textBoxlocationOfWavFileToPlayAtEndOfBreak;
        public Timer timerMicrobreak;
        private CheckBox checkBoxResetBreakOnWorkstationUnlock;
    }
}

