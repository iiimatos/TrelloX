using Microsoft.EntityFrameworkCore.Storage;

using TrelloX.Application.Common.Interfaces.Persistence;
using TrelloX.Domain.Entities;
using TrelloX.Infrastructure.Persistence.Repositories;

namespace TrelloX.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    private readonly IUserRepository? _userRepository;
    public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);

    public async Task<bool> CompletedTaskAsync()
        => await _context.SaveChangesAsync() > 0;

    public void Dispose()
    {
        _context.Dispose();
    }
}