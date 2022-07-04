using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioLabTimerInterfaces;

namespace BioLabTimerServices
{
    public class TimerService : ITimerService
    {
        /// <summary>
        /// Implementation of file persistence.
        /// </summary>
        /// <param name="timer"></param>
        /// <returns></returns>
        public bool SaveNewTimer(ITimer timer)
        {
            return true;
        }
    }
}
