using System.Data.Common;
using Dapper;
using EmployeeJourney.API.Common;
using EmployeeJourney.API.Models;
using EmployeeJourney.API.SQL;

namespace EmployeeJourney.API.Repository;

class EmployeeFeedbackRepository : IEmployeeFeedbackRepository
{

    private readonly DbConnection _connection;
    public EmployeeFeedbackRepository(DatabaseConnection connection)
    {
        _connection = connection.GetConnection();
    }
    public async Task<IEnumerable<EmployeeFeedback>> getAll()
    {
        var result = await _connection.QueryAsync<EmployeeFeedback>(EmployeeFeedbackSQL.SELECT_ALL);
        return result;
    }
    public async Task<EmployeeFeedback> get(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.QueryFirstAsync<EmployeeFeedback>(EmployeeFeedbackSQL.SELECT, parameters);
        return result;
    }
    public async Task<int> add(EmployeeFeedback employee)
    {
        var parameters = new
        {

        };
        var result = await _connection.ExecuteAsync(EmployeeFeedbackSQL.INSERT, parameters);
        return result;
    }
    public async Task<int> edit(EmployeeFeedback employee)
    {
        var parameters = new
        {

        };
        var result = await _connection.ExecuteAsync(EmployeeFeedbackSQL.UPDATE, parameters);
        return result;
    }
    public async Task<int> delete(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.ExecuteAsync(EmployeeFeedbackSQL.DELETE, parameters);
        return result;
    }
}