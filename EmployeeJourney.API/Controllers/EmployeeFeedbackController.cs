using EmployeeJourney.API.Models;
using EmployeeJourney.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeJourney.API.Controllers;

[ApiController]
[Route("api/v1/employee-feedback/")]
public class EmployeeFeedbackController : ControllerBase
{
    private readonly IEmployeeFeedbackRepository _repository;

    public EmployeeFeedbackController(IEmployeeFeedbackRepository repository)
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
    public async Task<IActionResult> Add(EmployeeFeedback employee)
    {
        return Ok(await _repository.add(employee));
    }
    [HttpPut]
    public async Task<IActionResult> Edit(EmployeeFeedback employee)
    {
        return Ok(await _repository.edit(employee));
    }
    [HttpDelete("{id_employee}")]
    public async Task<IActionResult> Delete(int id_employee)
    {
        return Ok(await _repository.delete(id_employee));
    }
}
