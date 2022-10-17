using Dapper;
using EmployeeJourney.API.Common;
using EmployeeJourney.API.Models;
using EmployeeJourney.API.SQL;
using MySql.Data.MySqlClient;

namespace EmployeeJourney.API.Repository;

class EmployeeRepository : IEmployeeRepository
{
    private readonly MySqlConnection _connection;
    public EmployeeRepository(DatabaseConnection connection)
    {
        _connection = connection.GetConnection();

    }

    public Task<Employee> add(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> delete(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> edit(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> get(int id_employee)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Employee>> getAll()
    {

        var employees = await _connection.QueryAsync<Employee>(EmployeeSQL.SELECT_ALL);
        return employees;
    }
}