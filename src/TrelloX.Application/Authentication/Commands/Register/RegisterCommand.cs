using ErrorOr;
using MediatR;
using TrelloX.Application.Authentication.Common;

namespace TrelloX.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;