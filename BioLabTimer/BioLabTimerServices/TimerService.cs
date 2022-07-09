using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using BioLabTimerInterfaces;

namespace BioLabTimerServices
{
    public class TimerService : ITimerService
    {
        public bool PauseTimer(ITimerRunnable timer)
        {
            throw new NotImplementedException();
        }

        public bool ResetTimer(ITimerRunnable timer)
        {
            throw new NotImplementedException();
        }

        public bool ResumeTimer(ITimerRunnable timer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implementation of file persistence.
        /// </summary>
        /// <param name="timer"></param>
        /// <returns></returns>
        public bool SaveNewTimer(ITimer timer)
        {
            if (timer == null) return false;

            var heresthepath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(heresthepath);

            string fileName = "testsetest.json";
            string jsonString = JsonSerializer.Serialize(timer);

            // TODO: Check the directory exsiting. If not, create the folder BioLabTimer programatically.
            // Use System.IO.Directory.CreateDirectory(...)
            File.WriteAllText($"{ heresthepath}\\Downloads\\poop\\{fileName}", jsonString);
                        
            return true;
        }

        public bool StartTimer(ITimerRunnable timer)
        {
            throw new NotImplementedException();
        }
    }
}
