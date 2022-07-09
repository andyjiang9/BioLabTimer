using BioLabTimerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioLabTimerServices;
using Timer = BioLabTimerServices.Timer;


namespace BioLabTimer.Popups
{
    internal class TimerDetailPopupViewModel
    {
        private ITimer _timer = new Timer();

        public void TimerDetailPopupViewMode()
        {            
        }

        public void TimerDetailPopupViewMode(ITimer timer)
        {             
            _timer = (timer == null) ? new Timer() : timer;
        }

        public int Hours { get; set; }
        public static int MinHours => 0;
        public static int MaxHours => 24*365;

        public int Minutes { get; set; }
        public static int MinMinutes => 0;
        public static int MaxMinuates => 59;

        public int Seconds { get; set; }
        public static int MinSeconds => 0;
        public static int MaxSeconds => 59;

        public string Title { get; set; }

        public void Save()
        {
            var service = new TimerService();

            // TODO: Add validation for the timer, such as but limited to:
            // 1. Not empty and not whitespace Title with minimal length of 3 letters.
            // 2. 0-99 for hours
            // 3. 0-59 for minutes
            // 4. 0-59 for seconds

            service.SaveNewTimer(new Timer
            {
                Title = this.Title,
                Hours = this.Hours,
                Minutes = this.Minutes,
                Seconds = this.Seconds
            });
        }
    }
}
