
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public IActionResult AdminOnly() => Ok("Welcome Admin");

    [Authorize(Roles = "User")]
    [HttpGet("user")]
    public IActionResult UserOnly() => Ok("Welcome User");

    [Authorize]
    [HttpGet("any")]
    public IActionResult AnyAuthenticated() => Ok("You're logged in");
}
