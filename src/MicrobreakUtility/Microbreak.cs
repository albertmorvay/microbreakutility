using System;
using System.IO;
using System.Windows.Forms;

namespace MicrobreakUtility
{
    static class Microbreak
    {
        static public double _intervalBetweenMicrobreaksInMinutes;
        static public double _durationOfMicrobreaksInMinutes;
        static public double _postponeMicrobreakInMinutes;
        static public bool PlaySoundAtStartOfBreak;
        static public bool PlaySoundAtEndOfBreak;
        static public string locationOfWavFileToPlayAtStartOfBreak;
        static public string locationOfWavFileToPlayAtEndOfBreak;
        static public DateTime _nextBreak;
        static public DateTime endOfCurrentBreak;
        static public bool _microbreakInProgress = false;
        static public bool ResetBreakOnWorkstationUnlock;
        static System.Timers.Timer timer = new System.Timers.Timer();


        public static void InitializeSettings()
        {
            _intervalBetweenMicrobreaksInMinutes = Properties.Settings.Default.IntervalBetweenMicrobreaksInMins;
            _durationOfMicrobreaksInMinutes = Properties.Settings.Default.DurationOfMicrobreaksInMins;
            _postponeMicrobreakInMinutes = Properties.Settings.Default.PostponeMicrobreakInMinutes;
            PlaySoundAtStartOfBreak = Properties.Settings.Default.PlaySoundAtStartOfBreak;
            PlaySoundAtEndOfBreak = Properties.Settings.Default.PlaySoundAtEndOfBreak;
            locationOfWavFileToPlayAtStartOfBreak = Properties.Settings.Default.LocationOfWavFileToPlayAtStartOfBreak;
            locationOfWavFileToPlayAtEndOfBreak = Properties.Settings.Default.LocationOfWavFileToPlayAtEndOfBreak;
            ResetBreakOnWorkstationUnlock = Properties.Settings.Default.ResetBreakOnWorkstationUnlock;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        public static bool TimeForABreak()
        {
            return (_nextBreak <= DateTime.Now && !_microbreakInProgress);
        }

        public static void SetTimeOfNextBreak(Form1 form1)
        {
            SetTimeOfNextBreak(_intervalBetweenMicrobreaksInMinutes, form1);
        }

        private static void SetTimeOfNextBreak(double microbreakDueInMinutes, Form1 form1)
        {
            _nextBreak = DateTime.Now.AddMinutes(microbreakDueInMinutes);
            _nextBreak = _nextBreak.AddSeconds(1);
            _microbreakInProgress = false;
            form1.BreakEnd();
        }

        public static void PostponeBreak(Form1 form1)
        {
            SetTimeOfNextBreak(_postponeMicrobreakInMinutes, form1);
        }

        public static void SetEndOfCurrentBreak()
        {
            endOfCurrentBreak = DateTime.Now.AddMinutes(_durationOfMicrobreaksInMinutes);
            endOfCurrentBreak = endOfCurrentBreak.AddSeconds(1);
        }

        public static TimeSpan TimeUntilNextBreak()
        {
            return _nextBreak - DateTime.Now;
        }

        public static TimeSpan TimeRemainingOfCurrentBreak()
        {
            return endOfCurrentBreak - DateTime.Now;
        }

        public static void PlayASoundAtStartOfBreak()
        {
            if (PlaySoundAtStartOfBreak)
                PlaySound(locationOfWavFileToPlayAtStartOfBreak);
        }

        public static void PlayASoundAtEndOfBreak()
        {
            if (PlaySoundAtEndOfBreak)
                PlaySound(locationOfWavFileToPlayAtEndOfBreak);
        }

        private static void PlaySound(string soundFileLocation)
        {
            if (File.Exists(soundFileLocation) && PlaySoundAtStartOfBreak || PlaySoundAtEndOfBreak)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFileLocation);
                player.Play();
            }
        }
    }
}
