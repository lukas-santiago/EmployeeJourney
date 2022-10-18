using EmployeeJourney.API.Models;

namespace EmployeeJourney.API.Repository;
public interface IEmployeeRepository
{
    public Task<IEnumerable<Employee>> getAll();
    public Task<Employee> get(int id_employee);
    public Task<int> add(Employee employee);
    public Task<int> edit(Employee employee);
    public Task<int> delete(int id_employee);
}
