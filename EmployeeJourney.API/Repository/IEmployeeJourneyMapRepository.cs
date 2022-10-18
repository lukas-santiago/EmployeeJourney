
using EmployeeJourney.API.Models;

namespace EmployeeJourney.API.Repository;

public interface IEmployeeJourneyMapRepository
{
    public Task<IEnumerable<EmployeeJourneyMap>> getAll();
    public Task<EmployeeJourneyMap> get(int id_employee);
    public Task<int> add(EmployeeJourneyMap employee);
    public Task<int> edit(EmployeeJourneyMap employee);
    public Task<int> delete(int id_employee);
}
