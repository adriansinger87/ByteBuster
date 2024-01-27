using ByteBuster.Ui.Maui.Pages;

namespace ByteBuster.Ui.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(HighscorePage), typeof(HighscorePage));
    }
}