using System.Reflection;

using Microsoft.EntityFrameworkCore;

using TrelloX.Application.Data;
using TrelloX.Domain.Entities;

namespace TrelloX.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Project> Projects { get; set; }

    public DbSet<Domain.Entities.Task> Tasks { get; set; }

    public DbSet<Label> Labels { get; set; }

    public DbSet<TaskLabel> TaskLabels { get; set; }

    public DbSet<Comment> Comments { get; set; }
}