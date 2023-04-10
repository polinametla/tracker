using Microsoft.Extensions.DependencyInjection;
using Tracker.Application.Services.Authentication;

namespace Tracker.Application;

public static class DI
{
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		services.AddScoped<IAuthenticationService, AuthenticationService>();

		return services;
	}
}