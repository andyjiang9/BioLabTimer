using BioLabTimerInterfaces;

namespace BioLabTimerServices
{
    internal class TimerRunnable : Timer, ITimerRunnable
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimerStatuses RunnableStatus { get; set; }
    }
}
