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
            this.tabPageSettings = new System.Windows.Forms.TabPage();
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
            this.timerMicrobreak = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPostponeBreakBy = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTimeUntilNextBreak = new System.Windows.Forms.Label();
            this.buttonBreakNow = new System.Windows.Forms.Button();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalBetweenBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationOfBreaks)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostponeBreakBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageHome.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(435, 234);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSettings
            // 
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
            this.tabPageSettings.Size = new System.Drawing.Size(427, 208);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(346, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "mins.";
            // 
            // numericUpDownIntervalBetweenBreaks
            // 
            this.numericUpDownIntervalBetweenBreaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numericUpDownIntervalBetweenBreaks.Location = new System.Drawing.Point(274, 64);
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
            this.numericUpDownIntervalBetweenBreaks.Size = new System.Drawing.Size(66, 31);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(22, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Interval between breaks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(294, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "mins.";
            // 
            // numericUpDownDurationOfBreaks
            // 
            this.numericUpDownDurationOfBreaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numericUpDownDurationOfBreaks.Location = new System.Drawing.Point(222, 18);
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
            this.numericUpDownDurationOfBreaks.Size = new System.Drawing.Size(66, 31);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
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
            this.tabPageAbout.Size = new System.Drawing.Size(427, 208);
            this.tabPageAbout.TabIndex = 1;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelVersionField
            // 
            this.labelVersionField.AutoSize = true;
            this.labelVersionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelVersionField.Location = new System.Drawing.Point(251, 112);
            this.labelVersionField.Name = "labelVersionField";
            this.labelVersionField.Size = new System.Drawing.Size(43, 25);
            this.labelVersionField.TabIndex = 6;
            this.labelVersionField.Text = "v.X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(82, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Software version";
            // 
            // linkLabelToIcons8
            // 
            this.linkLabelToIcons8.AutoSize = true;
            this.linkLabelToIcons8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelToIcons8.Location = new System.Drawing.Point(251, 33);
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
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Icons courtesy of";
            // 
            // timerMicrobreak
            // 
            this.timerMicrobreak.Tick += new System.EventHandler(this.timerMicrobreak_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.Location = new System.Drawing.Point(309, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "mins.";
            // 
            // numericUpDownPostponeBreakBy
            // 
            this.numericUpDownPostponeBreakBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numericUpDownPostponeBreakBy.Location = new System.Drawing.Point(237, 109);
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
            this.numericUpDownPostponeBreakBy.Size = new System.Drawing.Size(66, 31);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.Location = new System.Drawing.Point(22, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postpone breaks by:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MicrobreakUtility.Properties.Resources.HeartHealth;
            this.pictureBox2.Location = new System.Drawing.Point(24, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MicrobreakUtility.Properties.Resources.Icons8Logo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTimeUntilNextBreak
            // 
            this.labelTimeUntilNextBreak.AutoSize = true;
            this.labelTimeUntilNextBreak.Font = new System.Drawing.Font("Calibri", 57.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeUntilNextBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTimeUntilNextBreak.Location = new System.Drawing.Point(105, 41);
            this.labelTimeUntilNextBreak.Name = "labelTimeUntilNextBreak";
            this.labelTimeUntilNextBreak.Size = new System.Drawing.Size(217, 94);
            this.labelTimeUntilNextBreak.TabIndex = 6;
            this.labelTimeUntilNextBreak.Text = "00:00";
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
            this.buttonBreakNow.Location = new System.Drawing.Point(178, 129);
            this.buttonBreakNow.Name = "buttonBreakNow";
            this.buttonBreakNow.Size = new System.Drawing.Size(68, 68);
            this.buttonBreakNow.TabIndex = 7;
            this.buttonBreakNow.UseVisualStyleBackColor = false;
            this.buttonBreakNow.Click += new System.EventHandler(this.buttonBreakNow_Click);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.buttonBreakNow);
            this.tabPageHome.Controls.Add(this.labelTimeUntilNextBreak);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(427, 208);
            this.tabPageHome.TabIndex = 2;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 231);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micrbreak Utility";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalBetweenBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationOfBreaks)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostponeBreakBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Timer timerMicrobreak;
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
    }
}

