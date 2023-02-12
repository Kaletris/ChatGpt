using Microsoft.AspNetCore.Mvc;

namespace ChatGpt.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase
{
    [HttpGet("{firstName}")]
    public string Hello(string firstName, string? lastName)
    {
        return lastName == null
            ? $"Hello {firstName}"
            : $"Hello {firstName} {lastName}";
    }
}