using ByteBuster.Ui.Maui.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ByteBuster.Ui.Maui.ViewModels;

public partial class MainViewModel  : ObservableObject
{
    [RelayCommand]
    async Task Tap(string commnand)
    {
        await Shell.Current.GoToAsync(nameof(HighscorePage));
    }
}