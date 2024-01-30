using ByteBuster.Ui.Maui.ViewModels;

namespace ByteBuster.Ui.Maui.Pages;

public partial class HighscorePage : ContentPage
{
    public HighscorePage(HighscoreViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}