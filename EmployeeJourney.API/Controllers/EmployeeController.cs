using EmployeeJourney.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeJourney.API.Controllers;

[ApiController]
[Route("api/employee/")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _repository;

    public EmployeeController(IEmployeeRepository repository)
    {
        _repository = repository;
    }
    [HttpGet(Name = "/")]
    public async Task<IActionResult> Index()
    {
        return Ok(await _repository.getAll());
    }
}