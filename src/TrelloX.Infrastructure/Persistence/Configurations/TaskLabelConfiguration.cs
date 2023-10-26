using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrelloX.Domain.Entities;

namespace TrelloX.Infrastructure.Persistence.Configurations;

public class TaskLabelConfiguration : IEntityTypeConfiguration<TaskLabel>
{
	public void Configure(EntityTypeBuilder<TaskLabel> builder)
	{
		builder.HasKey(tl => new { tl.TaskId, tl.LabelId });

		builder.HasOne(tl => tl.Task)
			.WithMany(t => t.Items)
			.HasForeignKey(tl => tl.TaskId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasOne(tl => tl.Label)
			.WithMany(l => l.Items)
			.HasForeignKey(tl => tl.LabelId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}