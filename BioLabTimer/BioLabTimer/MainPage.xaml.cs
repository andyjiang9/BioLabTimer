namespace BioLabTimer;

using BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;

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
}

