using Microsoft.EntityFrameworkCore;

using TrelloX.Application.Common.Interfaces.Persistence;
using TrelloX.Domain.Entities;

namespace TrelloX.Infrastructure.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
	public UserRepository(ApplicationDbContext context) : base(context) { }

    public async Task<User?> GetUserByEmail(string email)
    {
        return await _entities.SingleOrDefaultAsync(u => u.Email == email);
    }
}