using EmployeeJourney.API.Models;
using EmployeeJourney.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeJourney.API.Controllers;

[ApiController]
[Route("api/employee-journey-map/")]
public class EmployeeJourneyMapController : ControllerBase
{
    private readonly IEmployeeJourneyMapRepository _repository;

    public EmployeeJourneyMapController(IEmployeeJourneyMapRepository repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.getAll());
    }
    [HttpGet("{id_employee}")]
    public async Task<IActionResult> GetOne(int id_employee)
    {
        return Ok(await _repository.get(id_employee));
    }
    [HttpPost]
    public async Task<IActionResult> Add(EmployeeJourneyMap employee)
    {
        return Ok(await _repository.add(employee));
    }
    [HttpPut]
    public async Task<IActionResult> Edit(EmployeeJourneyMap employee)
    {
        return Ok(await _repository.edit(employee));
    }
    [HttpDelete("{id_employee}")]
    public async Task<IActionResult> Delete(int id_employee)
    {
        return Ok(await _repository.delete(id_employee));
    }
}