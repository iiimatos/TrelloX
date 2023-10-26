using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrelloX.Domain.Entities;

namespace TrelloX.Infrastructure.Persistence.Configurations;

public class LabelConfiguration : IEntityTypeConfiguration<Label>
{
	public void Configure(EntityTypeBuilder<Label> builder)
	{
		builder.HasKey(u => u.Id);

		builder.Property(l => l.Name)
			.HasMaxLength(255)
			.IsRequired();

		builder.HasMany(l => l.Items)
			.WithOne(i => i.Label)
			.HasForeignKey(i => i.LabelId);
	}
}