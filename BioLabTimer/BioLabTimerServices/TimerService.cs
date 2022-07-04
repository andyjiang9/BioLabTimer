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
            File.WriteAllText($"{ heresthepath}\\Downloads\\poop\\{fileName}", jsonString);

            

            return true;
        }
    }
}
