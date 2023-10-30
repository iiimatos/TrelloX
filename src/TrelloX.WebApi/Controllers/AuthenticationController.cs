using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using TrelloX.Application.Authentication.Commands.Register;
using TrelloX.Domain.Contracts.Authentication;

namespace TrelloX.WebApi.Controllers;

[AllowAnonymous]
[Route("api/auth")]
public class AuthenticationController : ApiController
{
	private readonly ISender _mediator;

	public AuthenticationController(ISender mediator)
	{
		_mediator = mediator;
	}

    [Route("register")]
	[HttpPost]
	public async Task<IActionResult> Register(RegisterRequest request)
	{
		var command = new RegisterCommand(
			request.FirstName,
			request.LastName,
			request.Email,
			request.Password);
		var authenticationResult = await _mediator.Send(command);

		return authenticationResult.Match(
			authenticationResult => Ok(new AuthenticationResponse(
				authenticationResult.User.Id,
				authenticationResult.User.FirstName,
				authenticationResult.User.LastName,
				authenticationResult.User.Email,
				authenticationResult.Token)),
			errors => Problem(errors));
	}
}