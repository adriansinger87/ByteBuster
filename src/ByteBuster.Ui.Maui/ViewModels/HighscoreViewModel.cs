using CommunityToolkit.Mvvm.ComponentModel;

namespace ByteBuster.Ui.Maui.ViewModels;

public partial class HighscoreViewModel : ObservableObject
{
    [ObservableProperty]
    private string title;

    public HighscoreViewModel()
    {
        title = "Your Highscore";
    }
}