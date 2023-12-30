using chronos.usecases;

namespace numpitz.device;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDeviceServices(this IServiceCollection services)
        => services
            .AddSingleton<IAlarmService, AlarmService>();
}
