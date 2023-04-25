using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tracker.Application.Common.Interfaces.Authentication;
using Tracker.Application.Common.Interfaces.Services;
using Tracker.Infrastructure.Authentication;
using Tracker.Infrastructure.Services;

namespace Tracker.Infrastructure;

public static class DI
{
	public static IServiceCollection AddInfrastructure(
		this IServiceCollection services,
		ConfigurationManager configuration)
	{
		services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

		services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
		services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

		return services;
	}
}