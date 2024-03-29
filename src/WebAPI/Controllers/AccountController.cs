using Application.Account.Commands;
using Application.Account.Queries;
using Application.Common.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Authorize]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
public class AccountController : ApiControllerBase
{
    [HttpPost("login")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserDto>> Login(LoginCommand request, CancellationToken cancellationToken)
    {
        var userDto = await Mediator.Send(request, cancellationToken);
        return userDto;
    }

    [HttpPost("logout")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Logout(CancellationToken cancellationToken)
    {
        await Mediator.Send(new LogoutCommand(), cancellationToken);
        return NoContent();
    }

    [HttpPut("update")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> UpdateUserDetails(UpdateAccountDetailsCommand request, CancellationToken cancellationToken)
    {
        var userDto = await Mediator.Send(request, cancellationToken);
        return userDto;
    }

    [HttpPut("update-image")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<string?>> UpdateAccountImage(UpdateAccountImageCommand request, CancellationToken cancellationToken)
    {
        var image = await Mediator.Send(request, cancellationToken);
        return Ok(image);
    }

    [HttpGet("get-current-user")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<UserDto>> GetCurrentUser(CancellationToken cancellationToken)
    {
        var userDto = await Mediator.Send(new GetCurrentUserQuery(), cancellationToken);

        return userDto;
    }
}