using EmployeeJourney.API.Models;

namespace EmployeeJourney.API.Repository;

public interface IEmployeeFeedbackRepository
{
    public Task<IEnumerable<EmployeeFeedback>> getAll();
    public Task<EmployeeFeedback> get(int id_employee);
    public Task<int> add(EmployeeFeedback employee);
    public Task<int> edit(EmployeeFeedback employee);
    public Task<int> delete(int id_employee);
}
