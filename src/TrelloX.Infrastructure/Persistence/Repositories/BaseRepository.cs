using Microsoft.EntityFrameworkCore;

using TrelloX.Application.Common.Interfaces.Persistence;

namespace TrelloX.Infrastructure.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    protected DbSet<T> _entities
    {
        get
        {
            return _context.Set<T>();
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
        => await _entities.ToListAsync();

    public async Task<T?> GetByIdAsync(short id)
        => await _entities.FindAsync(id);

    public async Task DeleteAsync(T entity)
    {
        _entities.Remove(entity);
        await Task.CompletedTask;
    }

    public async Task InsertAsync(T entity)
    {
        await _entities.AddAsync(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        _entities.Update(entity);
        await Task.CompletedTask;
    }
}