using Microsoft.Extensions.DependencyInjection;

namespace Tracker.Infrastructure;

public static class DI
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services)
	{
		return services;
	}
}