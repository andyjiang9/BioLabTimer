namespace BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;

public partial class SettingsDetailPopup : Popup
{
    SettingsDetailPopupViewModel _viewModel;

    internal SettingsDetailPopup(SettingsDetailPopupViewModel viewModel)
    {
        InitializeComponent();

        _viewModel = viewModel;

        BindingContext = viewModel;
    }

}