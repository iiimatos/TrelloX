using TrelloX.Domain.Entities;

namespace TrelloX.Application.Common.Interfaces.Persistence;

public interface IUserRepository : IBaseRepository<User>
{
  Task<User?> GetUserByEmail(string email);
}