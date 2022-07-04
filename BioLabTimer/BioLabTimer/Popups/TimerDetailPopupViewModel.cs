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
    public class TimerDetailPopupViewModel
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
