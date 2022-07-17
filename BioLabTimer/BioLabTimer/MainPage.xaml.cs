namespace BioLabTimer;

using BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;


public partial class MainPage : ContentPage
{
    private readonly IFolderPicker _folderPicker;
    public MainPage(IFolderPicker folderPicker)
	{
		InitializeComponent();

        BindingContext = new MainViewModel();

        _folderPicker = folderPicker;
    }

    private void OnNewTimerClicked(object sender, EventArgs e)
    {
		var viewModel = new TimerDetailPopupViewModel();
        var popup = new TimerDetailPopup(viewModel);

        this.ShowPopup(popup);
    }

    private void SettingsClicked(object sender, EventArgs e)
    {
        var viewModel = new SettingsDetailPopupViewModel();
        var popup = new SettingsDetailPopup(viewModel, _folderPicker);

        this.ShowPopup(popup);
    }

    private void AboutUsClicked(object sender, EventArgs e)
    {
        var viewModel = new AboutUsDetailPopupViewModel();
        var popup = new AboutUsDetailPopup(viewModel);

        this.ShowPopup(popup);
    }

    private void SoundClicked(object sender, EventArgs e)
    {
        
    }
}

