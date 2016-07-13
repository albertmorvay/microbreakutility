using MicrobreakUtility.Helpers;
using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MicrobreakUtility
{
    public partial class Form1 : Form
    {
        private FormReminder formReminder;
        private bool _isMinimized = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Microbreak.InitializeSettings();
            PopulateControlsUnderSettingsTab();
            PopulateControlsUnderAboutTab();
            Microbreak.SetTimeOfNextBreak(this);
        }

        private  void PopulateControlsUnderSettingsTab()
        {
            numericUpDownDurationOfBreaks.Value = Convert.ToDecimal(Microbreak._durationOfMicrobreaksInMinutes);
            numericUpDownIntervalBetweenBreaks.Value = Convert.ToDecimal(Microbreak._intervalBetweenMicrobreaksInMinutes);
            numericUpDownPostponeBreakBy.Value = Convert.ToDecimal(Microbreak._postponeMicrobreakInMinutes);
            checkBoxPlaySoundAtStartOfBreak.Checked = Microbreak.PlaySoundAtStartOfBreak;
            checkBoxPlaySoundAtEndOfBreak.Checked = Microbreak.PlaySoundAtEndOfBreak;
            textBoxLocationOfWavFileToPlayAtStartOfBreak.Text = Microbreak.locationOfWavFileToPlayAtStartOfBreak;
            textBoxlocationOfWavFileToPlayAtEndOfBreak.Text = Microbreak.locationOfWavFileToPlayAtEndOfBreak;
            checkBoxResetBreakOnWorkstationUnlock.Checked = Microbreak.ResetBreakOnWorkstationUnlock;
        }

        private void PopulateControlsUnderAboutTab()
        {
            labelVersionField.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void BreakStart()
        {
            buttonBreakNow.Enabled = false;
            Microbreak.SetEndOfCurrentBreak();
            formReminder = new FormReminder(this);
            formReminder.Show();
            Microbreak._microbreakInProgress = true;
            timerMicrobreak.Stop();
        }

        public void BreakEnd()
        {
            timerMicrobreak.Start();
            buttonBreakNow.Enabled = true;
        }

        private void UpdateTimeUntilNextBreak()
        {
            var timeUntilBreak = Microbreak.TimeUntilNextBreak();
            labelTimeUntilNextBreak.Text = string.Format("{0}:{1}", timeUntilBreak.ToString("mm"), timeUntilBreak.ToString("ss"));
        }

        private void linkLabelToIcons8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com/");
        }

        private void numericUpDownDurationOfBreaks_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DurationOfMicrobreaksInMins = Convert.ToDouble(numericUpDownDurationOfBreaks.Value);
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void numericUpDownIntervalBetweenBreaks_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervalBetweenMicrobreaksInMins = Convert.ToDouble(numericUpDownIntervalBetweenBreaks.Value);
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void numericUpDownPostponeBreakBy_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PostponeMicrobreakInMinutes = Convert.ToDouble(numericUpDownPostponeBreakBy.Value);
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void buttonBreakNow_Click(object sender, EventArgs e)
        {
            Microbreak._nextBreak = DateTime.Now.AddSeconds(1);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BreakStart();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                MinimizeForm();
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = true;
                Show();
                WindowState = FormWindowState.Normal;
                TopMost = true;
                TopMost = false;
                _isMinimized = false;
                FormPositioning.ScreenRightAtTheBottom(this);
            }
        }

        public void MinimizeForm()
        {
            _isMinimized = true;
            ShowInTaskbar = false;
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!_isMinimized && WindowState == FormWindowState.Minimized)
            {
                MinimizeForm();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetCountdownToNextBreak();
        }
        
        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionUnlock && Microbreak.ResetBreakOnWorkstationUnlock)
                ResetCountdownToNextBreak();
        }

        private void ResetCountdownToNextBreak()
        {
            Microbreak.SetTimeOfNextBreak(this);
            if (formReminder != null)
                formReminder.Close();
        }

        private void checkBoxResetBreakOnWorkstationUnlock_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ResetBreakOnWorkstationUnlock = checkBoxResetBreakOnWorkstationUnlock.Checked;
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void checkBoxPlaySoundAtStartOfBreak_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlaySoundAtStartOfBreak = checkBoxPlaySoundAtStartOfBreak.Checked;
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void textBoxLocationOfWavFileToPlayAtStartOfBreak_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocationOfWavFileToPlayAtStartOfBreak = textBoxLocationOfWavFileToPlayAtStartOfBreak.Text;
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void checkBoxPlaySoundAtEndOfBreak_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlaySoundAtEndOfBreak = checkBoxPlaySoundAtEndOfBreak.Checked;
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void textBoxlocationOfWavFileToPlayAtEndOfBreak_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocationOfWavFileToPlayAtEndOfBreak = textBoxlocationOfWavFileToPlayAtEndOfBreak.Text;
            Properties.Settings.Default.Save();
            Microbreak.InitializeSettings();
        }

        private void timerMicrobreak_Tick(object sender, EventArgs e)
        {
            if (Microbreak.TimeForABreak())
            {
                BreakStart();
            }
            UpdateTimeUntilNextBreak();
        }
    }
}
