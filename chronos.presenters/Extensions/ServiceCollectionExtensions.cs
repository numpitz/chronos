using chronos.presenters.ViewModel;

namespace numpitz.device;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresenterServices(this IServiceCollection services)
        => services.AddTransient<Watch>();
}
