using MicrobreakUtility.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MicrobreakUtility
{
    public partial class Form1 : Form
    {
        private double _intervalBetweenMicrobreaksInMinutes;
        private double _durationOfMicrobreaksInMinutes;
        private double _postponeMicrobreakInMinutes;
        public bool PlaySoundAtStartOfBreak;
        public bool PlaySoundAtEndOfBreak;
        public string locationOfWavFileToPlayAtStartOfBreak;
        public string locationOfWavFileToPlayAtEndOfBreak;
        private DateTime _nextBreak;
        public DateTime endOfCurrentBreak;
        private bool _microbreakInProgress = false;
        private FormReminder formReminder;
        private bool _isMinimized = true;

        public Form1()
        {
            InitializeComponent();
            labelVersionField.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSettings();
            SetTimeOfNextBreak();
            timerMicrobreak.Start();
        }

        private void InitializeSettings()
        {
            _intervalBetweenMicrobreaksInMinutes = Properties.Settings.Default.IntervalBetweenMicrobreaksInMins;
            _durationOfMicrobreaksInMinutes = Properties.Settings.Default.DurationOfMicrobreaksInMins;
            _postponeMicrobreakInMinutes = Properties.Settings.Default.PostponeMicrobreakInMinutes;
            numericUpDownDurationOfBreaks.Value = Convert.ToDecimal(_durationOfMicrobreaksInMinutes);
            numericUpDownIntervalBetweenBreaks.Value = Convert.ToDecimal(_intervalBetweenMicrobreaksInMinutes);
            numericUpDownPostponeBreakBy.Value = Convert.ToDecimal(_postponeMicrobreakInMinutes);
            PlaySoundAtStartOfBreak = Properties.Settings.Default.PlaySoundAtStartOfBreak;
            PlaySoundAtEndOfBreak = Properties.Settings.Default.PlaySoundAtEndOfBreak;
            locationOfWavFileToPlayAtStartOfBreak = Properties.Settings.Default.LocationOfWavFileToPlayAtStartOfBreak;
            locationOfWavFileToPlayAtEndOfBreak = Properties.Settings.Default.LocationOfWavFileToPlayAtEndOfBreak;
            checkBoxPlaySoundAtStartOfBreak.Checked = Properties.Settings.Default.PlaySoundAtStartOfBreak;
            checkBoxPlaySoundAtEndOfBreak.Checked = Properties.Settings.Default.PlaySoundAtEndOfBreak;
            textBoxLocationOfWavFileToPlayAtStartOfBreak.Text = Properties.Settings.Default.LocationOfWavFileToPlayAtStartOfBreak;
            textBoxlocationOfWavFileToPlayAtEndOfBreak.Text = Properties.Settings.Default.LocationOfWavFileToPlayAtEndOfBreak;
        }

        public void PostponeBreak()
        {
            SetTimeOfNextBreak(_postponeMicrobreakInMinutes);
        }

        public void SetTimeOfNextBreak()
        {
            SetTimeOfNextBreak(_intervalBetweenMicrobreaksInMinutes);
        }

        private void SetTimeOfNextBreak(double microbreakDueInMinutes)
        {
            _nextBreak = DateTime.Now.AddMinutes(microbreakDueInMinutes);
            _nextBreak = _nextBreak.AddSeconds(1);
            _microbreakInProgress = false;
            buttonBreakNow.Enabled = true;
            timerMicrobreak.Start();
        }

        private void SetEndOfCurrentBreak()
        {
            endOfCurrentBreak = DateTime.Now.AddMinutes(_durationOfMicrobreaksInMinutes);
            endOfCurrentBreak = endOfCurrentBreak.AddSeconds(1);
        }

        private void timerMicrobreak_Tick(object sender, EventArgs e)
        {
            if (_nextBreak <= DateTime.Now && !_microbreakInProgress)
            {
                buttonBreakNow.Enabled = false;
                SetEndOfCurrentBreak();
                formReminder = new FormReminder(this);
                formReminder.Show();
                _microbreakInProgress = true;
                timerMicrobreak.Stop();
            }
            UpdateTimeUntilNextBreak();
        }

        private void UpdateTimeUntilNextBreak()
        {
            var timeUntilBreak = (_nextBreak - DateTime.Now);
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
            InitializeSettings();
        }

        private void numericUpDownIntervalBetweenBreaks_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IntervalBetweenMicrobreaksInMins = Convert.ToDouble(numericUpDownIntervalBetweenBreaks.Value);
            Properties.Settings.Default.Save();
            InitializeSettings();
        }

        private void numericUpDownPostponeBreakBy_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PostponeMicrobreakInMinutes = Convert.ToDouble(numericUpDownPostponeBreakBy.Value);
            Properties.Settings.Default.Save();
            InitializeSettings();
        }

        private void buttonBreakNow_Click(object sender, EventArgs e)
        {
            buttonBreakNow.Enabled = false;
            _nextBreak = DateTime.Now.AddSeconds(1);
            
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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
                WindowState = FormWindowState.Normal;
                _isMinimized = false;
                PlaceLowerRight();
                Activate();
                TopMost = true;
                TopMost = false;
            }
        }

        public void MinimizeForm()
        {
            _isMinimized = true;
            ShowInTaskbar = false;
            Hide();            
            WindowState = FormWindowState.Minimized;
        }

        private void PlaceLowerRight()
        {
            Rectangle primaryScreenWorkingArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(primaryScreenWorkingArea.Right - Size.Width,
                                      primaryScreenWorkingArea.Bottom - (Size.Height-7));
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
            SetTimeOfNextBreak();
            if (formReminder != null)
                formReminder.Dispose();
        }

        private void checkBoxPlaySoundAtStartOfBreak_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlaySoundAtStartOfBreak = checkBoxPlaySoundAtStartOfBreak.Checked;
            Properties.Settings.Default.Save();
            InitializeSettings();
        }

        private void textBoxLocationOfWavFileToPlayAtStartOfBreak_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocationOfWavFileToPlayAtStartOfBreak = textBoxLocationOfWavFileToPlayAtStartOfBreak.Text;
            Properties.Settings.Default.Save();
            InitializeSettings();
        }

        private void checkBoxPlaySoundAtEndOfBreak_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlaySoundAtEndOfBreak = checkBoxPlaySoundAtEndOfBreak.Checked;
            Properties.Settings.Default.Save();
            InitializeSettings();
        }

        private void textBoxlocationOfWavFileToPlayAtEndOfBreak_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocationOfWavFileToPlayAtEndOfBreak = textBoxlocationOfWavFileToPlayAtEndOfBreak.Text;
            Properties.Settings.Default.Save();
            InitializeSettings();
        }
    }
}
