using Microsoft.AspNetCore.Mvc;

namespace MultipleSwaggerDocs.Controllers;

[ApiController]
[ApiExplorerSettings(GroupName = "example2")]
[Route("[controller]")]
public class Example2Controller : ControllerBase
{
    [HttpGet("/example2-endpoint")]
    public IActionResult Example2Endpoint()
    {
        return Ok("Example 2 worked!");
    }
}