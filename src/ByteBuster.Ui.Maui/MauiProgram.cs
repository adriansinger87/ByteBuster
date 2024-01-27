using ByteBuster.Ui.Maui.Pages;
using ByteBuster.Ui.Maui.ViewModels;
using Microsoft.Extensions.Logging;

namespace ByteBuster.Ui.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        builder.Services.AddTransient<HighscorePage>();
        builder.Services.AddTransient<HighscoreViewModel>();
        
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        return builder.Build();
    }
}