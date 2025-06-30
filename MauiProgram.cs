using Microsoft.Extensions.Logging;
//using Syncfusion.Maui.Core.Hosting;
using Microsoft.Maui.Handlers;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui;
namespace CICMmauiApp;


public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        //builder.ConfigureMauiHandlers(static handlers =>
        //{
        //    handlers.AddHandler<CustomButton, CustomButtonHandler>();
        //});
         
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        builder.UseMauiApp<App>();
        return builder.Build();



#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
