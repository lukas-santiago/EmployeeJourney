using EmployeeJourney.API.Models;

namespace EmployeeJourney.API.Repository;
public interface IEmployeeRepository
{
    public Task<IEnumerable<Employee>> getAll();
    public Task<Employee> get(int id_employee);
    public Task<Employee> add(Employee employee);
    public Task<Employee> edit(Employee employee);
    public Task<Employee> delete(Employee employee);
}
