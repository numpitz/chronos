using chronos.ui.Pages;

namespace numpitz.device;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
        => services.AddTransient<WatchPage>();
}
