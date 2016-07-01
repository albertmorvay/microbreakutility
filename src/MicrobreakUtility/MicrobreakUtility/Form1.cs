using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrobreakUtility
{
    public partial class Form1 : Form
    {
        private double _intervalBetweenMicrobreaksInMinutes;
        private double _durationOfMicrobreaksInMinutes;
        private double _postponeMicrobreakInMinutes;
        private DateTime _nextBreak;
        public DateTime endOfCurrentBreak;
        private bool _microbreakInProgress = false;
        private FormReminder formReminder;

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
    }
}
