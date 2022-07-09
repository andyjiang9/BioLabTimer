namespace BioLabTimerInterfaces
{
    public interface ITimerService
    {
        bool SaveNewTimer(ITimer timer);

        bool StartTimer(ITimerRunnable timer);

        bool PauseTimer(ITimerRunnable timer);

        bool ResumeTimer(ITimerRunnable timer);

        bool ResetTimer(ITimerRunnable timer);
    }
}