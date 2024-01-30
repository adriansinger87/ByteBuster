using ByteBuster.Ui.Maui.ViewModels;

namespace ByteBuster.Ui.Maui.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}