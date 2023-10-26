using TrelloX.Domain.Common;

namespace TrelloX.Domain.Entities;

public sealed class Comment : BaseEntity
{
    public string Text { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
    public User User { get; set; } = null!;
    public Task Task { get; set; } = null!;
}