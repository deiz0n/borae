using Microsoft.AspNetCore.Mvc;

namespace BoraeBackend.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HeathController : ControllerBase
{
 
    [HttpGet(Name = "GetHealthStatus")]
    public IActionResult GetHealthStatus()
    {
        return Ok(new 
        { 
            status = "Healthy", 
            timestamp = DateTime.UtcNow 
        }
        );
    }
}
