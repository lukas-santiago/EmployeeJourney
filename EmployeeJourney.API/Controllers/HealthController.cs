using Microsoft.AspNetCore.Mvc;

namespace EmployeeJourney.API.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet()]
    public IActionResult Index()
    {
        return Ok("Servidor está online");
    }
}