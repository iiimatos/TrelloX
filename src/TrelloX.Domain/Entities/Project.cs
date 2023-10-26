using TrelloX.Domain.Common;

namespace TrelloX.Domain.Entities;

public sealed class Project : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public IList<Task> Tasks { get; private set; } = new List<Task>();
}