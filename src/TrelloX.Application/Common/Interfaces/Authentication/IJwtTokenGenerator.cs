using TrelloX.Domain.Entities;

namespace TrelloX.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
  string GenerateToken(User user);
}