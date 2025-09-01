using IdentityService.Application.DTOs;
using IdentityService.Application.Login;
using IdentityService.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityService.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ISender _sender;

    public AuthController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login([FromQuery] LoginCommand loginCommand)
    {
        var res = await _sender.Send(loginCommand);
        return Ok(res);
    }

    [Authorize(policy: "email")]
    [HttpPost("register")]
    public ActionResult<UserDto> Register([FromBody] UserDto userDto)
    {
        // Logic for user registration
        return Ok(userDto);
    }
}