namespace MicrobreakUtility
{
    partial class FormReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReminder));
            this.buttonSkipBreak = new System.Windows.Forms.Button();
            this.buttonPostponeBreak = new System.Windows.Forms.Button();
            this.labelBreakTimeRemaining = new System.Windows.Forms.Label();
            this.timerMicrobreakDuration = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonSkipBreak
            // 
            this.buttonSkipBreak.BackColor = System.Drawing.Color.White;
            this.buttonSkipBreak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSkipBreak.FlatAppearance.BorderSize = 0;
            this.buttonSkipBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSkipBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSkipBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkipBreak.Image = global::MicrobreakUtility.Properties.Resources.Forward;
            this.buttonSkipBreak.Location = new System.Drawing.Point(292, 0);
            this.buttonSkipBreak.Name = "buttonSkipBreak";
            this.buttonSkipBreak.Size = new System.Drawing.Size(68, 68);
            this.buttonSkipBreak.TabIndex = 4;
            this.buttonSkipBreak.UseVisualStyleBackColor = false;
            this.buttonSkipBreak.Click += new System.EventHandler(this.buttonSkipBreak_Click);
            // 
            // buttonPostponeBreak
            // 
            this.buttonPostponeBreak.BackColor = System.Drawing.Color.White;
            this.buttonPostponeBreak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPostponeBreak.FlatAppearance.BorderSize = 0;
            this.buttonPostponeBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPostponeBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPostponeBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostponeBreak.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostponeBreak.Image = global::MicrobreakUtility.Properties.Resources.Future;
            this.buttonPostponeBreak.Location = new System.Drawing.Point(222, 0);
            this.buttonPostponeBreak.Name = "buttonPostponeBreak";
            this.buttonPostponeBreak.Size = new System.Drawing.Size(68, 69);
            this.buttonPostponeBreak.TabIndex = 3;
            this.buttonPostponeBreak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPostponeBreak.UseVisualStyleBackColor = false;
            this.buttonPostponeBreak.Click += new System.EventHandler(this.buttonPostponeBreak_Click);
            // 
            // labelBreakTimeRemaining
            // 
            this.labelBreakTimeRemaining.AutoSize = true;
            this.labelBreakTimeRemaining.Font = new System.Drawing.Font("Calibri", 57.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreakTimeRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelBreakTimeRemaining.Location = new System.Drawing.Point(3, -13);
            this.labelBreakTimeRemaining.Name = "labelBreakTimeRemaining";
            this.labelBreakTimeRemaining.Size = new System.Drawing.Size(217, 94);
            this.labelBreakTimeRemaining.TabIndex = 5;
            this.labelBreakTimeRemaining.Text = "00:00";
            // 
            // timerMicrobreakDuration
            // 
            this.timerMicrobreakDuration.Tick += new System.EventHandler(this.timerMicrobreakDuration_Tick);
            // 
            // FormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 68);
            this.Controls.Add(this.labelBreakTimeRemaining);
            this.Controls.Add(this.buttonSkipBreak);
            this.Controls.Add(this.buttonPostponeBreak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Microbreak reminder";
            this.Load += new System.EventHandler(this.FormReminder_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormReminder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPostponeBreak;
        private System.Windows.Forms.Button buttonSkipBreak;
        private System.Windows.Forms.Label labelBreakTimeRemaining;
        private System.Windows.Forms.Timer timerMicrobreakDuration;
    }
}