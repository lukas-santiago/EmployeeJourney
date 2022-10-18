using System.Data.Common;
using Dapper;
using EmployeeJourney.API.Common;
using EmployeeJourney.API.Models;
using EmployeeJourney.API.SQL;

namespace EmployeeJourney.API.Repository;

class EmployeeJourneyMapRepository : IEmployeeJourneyMapRepository
{

    private readonly DbConnection _connection;
    public EmployeeJourneyMapRepository(DatabaseConnection connection)
    {
        _connection = connection.GetConnection();
    }
    public async Task<IEnumerable<EmployeeJourneyMap>> getAll()
    {
        var result = await _connection.QueryAsync<EmployeeJourneyMap>(EmployeeJourneyMapSQL.SELECT_ALL);
        return result;
    }
    public async Task<EmployeeJourneyMap> get(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.QueryFirstAsync<EmployeeJourneyMap>(EmployeeJourneyMapSQL.SELECT, parameters);
        return result;
    }
    public async Task<int> add(EmployeeJourneyMap employee)
    {
        var parameters = new
        {

        };
        var result = await _connection.ExecuteAsync(EmployeeJourneyMapSQL.INSERT, parameters);
        return result;
    }
    public async Task<int> edit(EmployeeJourneyMap employee)
    {
        var parameters = new
        {

        };
        var result = await _connection.ExecuteAsync(EmployeeJourneyMapSQL.UPDATE, parameters);
        return result;
    }
    public async Task<int> delete(int id_employee)
    {
        var parameters = new
        {
            id_employee
        };
        var result = await _connection.ExecuteAsync(EmployeeJourneyMapSQL.DELETE, parameters);
        return result;
    }
}