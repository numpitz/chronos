using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using numpitz.device;
using numpitz.datastore;

namespace chronos.app
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services
            // Plugins - Frameworks & Drivers
                .AddDeviceServices()
                .AddDataStoreServices()
                .AddUIServices()
                .AddPresenterServices() // <- Presenters - Interface Adapters
                .AddUseCaseServices();  // <- Use Cases  - Application Business Rules 
                                       
            // Entities - Enterprise Business Rules
            // NOOP     ¯\_(ツ)_/¯

            return builder.Build();
        }
    }
}
