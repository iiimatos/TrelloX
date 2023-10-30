using TrelloX.Domain.Common;

namespace TrelloX.Domain.Entities;

public sealed class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public IList<Task> Tasks { get; private set; } = new List<Task>();
    public IList<Comment> Comments { get; private set; } = new List<Comment>();

    private User(
        Guid id,
        string firstName,
        string lastName,
        string email,
        string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public static User Create(
        string firstName,
        string lastName,
        string email,
        string password)
    {
        return new (
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            password
        );
    }
}