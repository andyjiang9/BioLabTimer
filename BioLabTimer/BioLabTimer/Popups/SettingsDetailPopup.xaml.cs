using Microsoft.Maui.Controls.PlatformConfiguration;

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

    internal void OnSaveClicked(object sender, EventArgs param)
    {

        _viewModel.Save();
    }

    internal void FindFolder(object sender, EventArgs param)
    {
      

       
    }

}