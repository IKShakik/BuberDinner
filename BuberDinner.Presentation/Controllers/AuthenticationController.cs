using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Presentation.Controllers;

[Route("Auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    [HttpPost("Register")]
    public IActionResult Register(RegisterRequest dto)
    {
        var authResult = _authenticationService.Register(dto.FirstName, dto.LastName, dto.Email, dto.Password);
        var response = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
            );
        return Ok(response);
    }
    
    [HttpPost("Login")]
    public IActionResult Login(LoginRequest dto)
    {
        var authResult = _authenticationService.Login(dto.Email, dto.Password);
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        return Ok(response);
    }
}