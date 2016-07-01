# MicrobreakUtility

A simple utility to unobtrusively remind you to get up from your workstation. Inspirde by [Matt Lester's Big Stretch Reminder](http://www.monkeymatt.com/bigstretch/) with the aim of providing a more unobtrusive open source solution we have the MicrobreakUtility.

## Requirements

### Under settings you can specify

- The duration of microbreaks;
- The Interval between microbreaks;
- Whether locking the workstation is counted as a break, resetting the interval timer on unlock;
- Whether a sound should be played at the beginning of a microbreak;
- Whether a sound should be played at the end of a microbreak;
- The *.wav file which should be played at the beginning of a microbreak;
- The *.wav file which should be played at the end of a microbreak;

### Microbreak

- The reminder will only be shown after the specified interval period has elapsed since the start of the application or the previous break;
- The reminder will only be shown for the specified duration;
- The reminder will be shown on the virtual desktop the user is currently on;
- If user alt-f4s out of break handle the issue