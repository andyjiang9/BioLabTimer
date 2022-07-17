namespace BioLabTimer;

using BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;

using WMPLib;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainViewModel();
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
        var popup = new SettingsDetailPopup(viewModel);

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
        //axWindowsMediaPlayer1.URL = @"c:\mediafile.wmv";
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        wplayer.URL = "C:\\Users\\Andy Jiang\\Videos\\.Useful Sound Effects\\We'll be right back Sound Effect meme.mp3";
        wplayer.controls.play();
    }
}

