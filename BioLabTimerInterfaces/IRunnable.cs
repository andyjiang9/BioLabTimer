namespace BioLabTimerInterfaces
{
    public interface IRunnable
    {
        TimerStatuses RunnableStatus { get; set; }

        DateTime? StartTime { get; set; }

        DateTime? EndTime { get; set; }
    }
}
