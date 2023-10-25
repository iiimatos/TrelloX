using TrelloX.Domain.Common;

namespace TrelloX.Domain.Entities;

public sealed class Label : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public IList<TaskLabel> Items { get; private set; } = new List<TaskLabel>();
}