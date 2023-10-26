using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrelloX.Domain.Entities;

namespace TrelloX.Infrastructure.Persistence.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
	public void Configure(EntityTypeBuilder<Project> builder)
	{
		builder.HasKey(u => u.Id);

		builder.Property(l => l.Name)
			.HasMaxLength(255)
			.IsRequired();

		builder.Property(l => l.Description)
			.HasMaxLength(500)
			.IsRequired();

		builder.Property(l => l.StartDate)
			.IsRequired();

		builder.Property(l => l.EndDate)
			.IsRequired();

		builder.HasOne(p => p.User)
			.WithMany()
			.HasForeignKey(p => p.UserId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}