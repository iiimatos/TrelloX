using TrelloX.Domain.Entities;

namespace TrelloX.Application.Authentication.Common;

public record AuthenticationResult(
	User User,
	string Token);