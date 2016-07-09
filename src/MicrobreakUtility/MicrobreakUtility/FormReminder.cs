using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MicrobreakUtility.Helpers;
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
        }

        private void PlaceLowerRight()
        {
            Rectangle primaryScreenWorkingArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point((primaryScreenWorkingArea.Right/2) - (Size.Width/2),
                                      primaryScreenWorkingArea.Bottom - Size.Height);
        }
        

        protected override void OnLoad(System.EventArgs e)
        {
            PlaceLowerRight();
            NativeMethods.AnimateWindow(this.Handle, 200,
                NativeMethods.AW_SLIDE
                | NativeMethods.AW_VER_NEGATIVE);


            IntPtr HWND_TOPMOST = new IntPtr(-1);
            uint SWP_NOACTIVATE = 0x0010;
            NativeMethods.SetWindowPos(Handle, HWND_TOPMOST, Location.X, Location.Y, Width, Height, SWP_NOACTIVATE);

            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            NativeMethods.AnimateWindow(this.Handle, 200,
                NativeMethods.AW_SLIDE 
                | NativeMethods.AW_VER_POSITIVE 
                | NativeMethods.AW_HIDE);

            base.OnClosing(e);
        }

        private void buttonPostponeBreak_Click(object sender, EventArgs e)
        {
            form1.PostponeBreak();
            Close();
        }

        private void buttonSkipBreak_Click(object sender, EventArgs e)
        {
            form1.SetTimeOfNextBreak();
            Close();
        }

        private void timerMicrobreakDuration_Tick(object sender, EventArgs e)
        {
            if (form1.endOfCurrentBreak <= DateTime.Now)
            {
                form1.SetTimeOfNextBreak();
                Close();
            }
            UpdateRemainingBreakTime();
        }

        private void UpdateRemainingBreakTime()
        {
            var timeRemainingOfBreak = (form1.endOfCurrentBreak - DateTime.Now);
            labelBreakTimeRemaining.Text = string.Format("{0}:{1}", timeRemainingOfBreak.ToString("mm"), timeRemainingOfBreak.ToString("ss"));
        }
    }
}
