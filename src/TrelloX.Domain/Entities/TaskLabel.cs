namespace TrelloX.Domain.Entities;

public sealed class TaskLabel
{
    public Task Task { get; set; } = null!;
    public Label Label { get; set; } = null!;
}