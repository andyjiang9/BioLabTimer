using Microsoft.Maui.Controls.PlatformConfiguration;

namespace BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;

public partial class SettingsDetailPopup : Popup
{
    SettingsDetailPopupViewModel _viewModel;

    private readonly IFolderPicker _folderPicker;

    internal SettingsDetailPopup(SettingsDetailPopupViewModel viewModel, IFolderPicker folderPicker)
    {
        InitializeComponent();

        _viewModel = viewModel;

        BindingContext = viewModel;

        _folderPicker = folderPicker;
    }

    internal void OnSaveClicked(object sender, EventArgs param)
    {

        _viewModel.Save();
    }

    internal async void FindFolder(object sender, EventArgs param)
    {
        var pickedFolder = await _folderPicker.PickFolder();
    }

    internal void CancelSettings(object sender, EventArgs param) => Close();

}