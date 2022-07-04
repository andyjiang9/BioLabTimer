using BioLabTimerInterfaces;

namespace BioLabTimerServices
{
    public class Timer : ITimer
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }
        
        public string Title { get; set; } = string.Empty;
    }
}