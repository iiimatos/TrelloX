using Microsoft.EntityFrameworkCore;

using TrelloX.Domain.Entities;

namespace TrelloX.Application.Data;

public interface IApplicationDbContext
{
	DbSet<User> Users { get; set; }
	DbSet<Project> Projects { get; set; }
	DbSet<Label> Labels { get; set; }
	DbSet<TaskLabel> TaskLabels { get; set; }
	DbSet<Comment> Comments { get; set; }

	Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}