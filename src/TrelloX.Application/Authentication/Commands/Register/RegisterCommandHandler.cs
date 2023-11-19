using ErrorOr;
using MediatR;
using TrelloX.Application.Authentication.Common;
using TrelloX.Application.Common.Interfaces.Authentication;
using TrelloX.Application.Common.Interfaces.Persistence;
using TrelloX.Domain.Common.Errors;
using TrelloX.Domain.Entities;

namespace TrelloX.Application.Authentication.Commands.Register;

public sealed class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUnitOfWork unitOfWork)
    {
        _jwtTokenGenerator = jwtTokenGenerator ?? throw new ArgumentException(nameof(jwtTokenGenerator));
        _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        await System.Threading.Tasks.Task.CompletedTask;

        if (await _unitOfWork.UserRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        var user = User.Create(
            command.FirstName,
            command.LastName,
            command.Email,
            command.Password
        );

        await _unitOfWork.UserRepository.InsertAsync(user);
        await _unitOfWork.CompletedTaskAsync();

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
}