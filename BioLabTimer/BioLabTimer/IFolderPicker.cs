namespace BioLabTimer
{
    public interface IFolderPicker
    {
        Task<string> PickFolder();
    }
}
