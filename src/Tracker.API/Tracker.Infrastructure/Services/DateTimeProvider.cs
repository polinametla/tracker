using Tracker.Application.Common.Interfaces.Services;

namespace Tracker.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
	public DateTime UtcNow => DateTime.UtcNow;
}
