using TrelloX.Domain.Common;

namespace TrelloX.Domain.Entities;

public sealed class Comment : BaseEntity
{
    public string Text { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public User UserId { get; set; } = null!;
    public Task TaskId { get; set; } = null!;
}