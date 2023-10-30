using TrelloX.Domain.Entities;

namespace TrelloX.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}