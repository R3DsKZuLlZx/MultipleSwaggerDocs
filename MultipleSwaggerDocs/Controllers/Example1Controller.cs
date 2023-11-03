using Microsoft.AspNetCore.Mvc;

namespace MultipleSwaggerDocs.Controllers;

[ApiController]
[ApiExplorerSettings(GroupName = "example1")]
[Route("[controller]")]
public class Example1Controller : ControllerBase
{
    [HttpGet("/example1-endpoint")]
    public IActionResult Example1Endpoint()
    {
        return Ok("Example 1 worked!");
    }
}
