using System.Data.Common;
using Dapper;
using EmployeeJourney.API.Common;
using EmployeeJourney.API.Models;
using EmployeeJourney.API.SQL;

namespace EmployeeJourney.API.Repository;

class EmployeeRepository : IEmployeeRepository
{
    private readonly DbConnection _connection;
    public EmployeeRepository(DatabaseConnection connection)
    {
        _connection = connection.GetConnection();
    }
    public async Task<IEnumerable<Employee>> getAll()
    {
        var result = await _connection.QueryAsync<Employee>(EmployeeSQL.SELECT_ALL);
        return result;
    }
    public async Task<Employee> get(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.QueryFirstAsync<Employee>(EmployeeSQL.SELECT, parameters);
        return result;
    }
    public async Task<int> add(Employee employee)
    {
        var parameters = new
        {
            id_employee = employee.id_employee,
            username = employee.username,
            first_name = employee.first_name,
            last_name = employee.last_name,
            email = employee.email,
            phone = employee.phone,
            gender = employee.gender,
            address = employee.address,
            department = employee.department,
            password = employee.password,
            abou = employee.about
        };
        var result = await _connection.ExecuteAsync(EmployeeSQL.INSERT, parameters);
        return result;
    }
    public async Task<int> edit(Employee employee)
    {
        var parameters = new
        {
            id_employee = employee.id_employee,
            username = employee.username,
            first_name = employee.first_name,
            last_name = employee.last_name,
            email = employee.email,
            phone = employee.phone,
            gender = employee.gender,
            address = employee.address,
            department = employee.department,
            password = employee.password,
            abou = employee.about
        };
        var result = await _connection.ExecuteAsync(EmployeeSQL.UPDATE, parameters);
        return result;
    }
    public async Task<int> delete(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.ExecuteAsync(EmployeeSQL.DELETE, parameters);
        return result;
    }
}