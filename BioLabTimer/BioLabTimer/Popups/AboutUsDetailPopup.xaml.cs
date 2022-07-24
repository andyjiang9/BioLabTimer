namespace BioLabTimer.Popups;
using CommunityToolkit.Maui.Views;

public partial class AboutUsDetailPopup : Popup
{
    AboutUsDetailPopupViewModel _viewModel;

    internal AboutUsDetailPopup(AboutUsDetailPopupViewModel viewModel)
    {
        InitializeComponent();

        _viewModel = viewModel;

        BindingContext = viewModel;
    }

    internal void CloseAboutUs(Object sender, EventArgs e) => Close();
}