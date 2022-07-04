namespace BioLabTimerInterfaces
{
    public interface ITimer
    {
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
        string Title { get; set; }
    }
}