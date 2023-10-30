using TrelloX.Application.Common.Interfaces.Authentication;

namespace TrelloX.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
	public DateTime UtcNow => DateTime.UtcNow;
}