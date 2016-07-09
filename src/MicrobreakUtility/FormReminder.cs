using MicrobreakUtility.Helpers;
using System;
using System.Windows.Forms;


namespace MicrobreakUtility
{
    public partial class FormReminder : Form
    {
        public FormReminder()
        {
            InitializeComponent();
        }

        private Form1 form1 = null;
        public FormReminder(Form callingForm)
        {
            form1 = callingForm as Form1;
            InitializeComponent();
        }

        private void FormReminder_Load(object sender, EventArgs e)
        {
            timerMicrobreakDuration.Start();
            Microbreak.PlayASoundAtStartOfBreak();
            form1.MinimizeForm();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            FormPositioning.ScreenCenterAtTheBottom(this);
            FormAnimations.SlideUpTopMostWithoutStealingFocus(this);
            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FormAnimations.SlideDown(this);
            base.OnFormClosing(e);
        }

        private void buttonPostponeBreak_Click(object sender, EventArgs e)
        {
            Microbreak.PostponeBreak(form1);
            Close();
        }

        private void buttonSkipBreak_Click(object sender, EventArgs e)
        {
            Microbreak.SetTimeOfNextBreak(form1);
            Close();
        }

        private void timerMicrobreakDuration_Tick(object sender, EventArgs e)
        {
            if (Microbreak.endOfCurrentBreak <= DateTime.Now)
            {
                Microbreak.PlayASoundAtEndOfBreak();
                Microbreak.SetTimeOfNextBreak(form1);
                Close();
            }
            UpdateRemainingBreakTime();
        }

        private void UpdateRemainingBreakTime()
        {
            var timeRemainingOfCurrentBreak = Microbreak.TimeRemainingOfCurrentBreak();
            labelBreakTimeRemaining.Text = string.Format("{0}:{1}", timeRemainingOfCurrentBreak.ToString("mm"), timeRemainingOfCurrentBreak.ToString("ss"));
        }
    }
}
