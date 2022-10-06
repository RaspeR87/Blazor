using BlazorWebAndMAUI.MAUI.Data;
using BlazorWebAndMAUI.Shared.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace BlazorWebAndMAUI.MAUI
{
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
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "ntkdb.db3");
            builder.Services.AddSingleton<INTKDBRepository, NTKDBRepository>(s => ActivatorUtilities.CreateInstance<NTKDBRepository>(s, dbPath));

            return builder.Build();
        }
    }
}