namespace TrelloX.Application.Common.Interfaces.Persistence;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    Task<bool> CompletedTaskAsync();
}