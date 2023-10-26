namespace TrelloX.Domain.Entities;

public sealed class TaskLabel
{
    public Guid TaskId { get; set; }
    public Guid LabelId { get; set; }
    public Task Task { get; set; } = null!;
    public Label Label { get; set; } = null!;
}