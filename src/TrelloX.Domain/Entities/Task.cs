using TrelloX.Domain.Common;
using TrelloX.Domain.Enums;

namespace TrelloX.Domain.Entities;

public sealed class Task : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public DateTime? DueDate { get; set; } = null;
    public TaskStatusType Status { get; set; } = TaskStatusType.Pending;
    public User UserId { get; set; } = null!;
    public Project ProjectId { get; set; } = null!;
    public IList<Comment> Comments { get; private set; } = new List<Comment>();
    public IList<TaskLabel> Items { get; private set; } = new List<TaskLabel>();
}