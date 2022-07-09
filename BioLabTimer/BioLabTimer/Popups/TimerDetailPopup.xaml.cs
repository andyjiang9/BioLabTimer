namespace BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;
 
public partial class TimerDetailPopup : Popup
{
	TimerDetailPopupViewModel _viewModel;

    internal TimerDetailPopup(TimerDetailPopupViewModel viewModel)
	{
		InitializeComponent();

		_viewModel = viewModel;

        BindingContext = viewModel;
	}

	internal void OnSaveClicked(object sender, EventArgs param)
    {

        _viewModel.Save();
    }
}