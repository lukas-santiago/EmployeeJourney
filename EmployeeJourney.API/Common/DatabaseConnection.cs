using System.Data.Common;
using System.Data.SqlClient;

namespace EmployeeJourney.API.Common;

class DatabaseConnection
{
    private readonly IConfiguration _configuration;
    private readonly DbConnection _connection;
    public DatabaseConnection(IConfiguration configuration)
    {
        _configuration = configuration;
        _connection = new SqlConnection(_configuration.GetConnectionString("MsSQLConnection"));
        _connection.Open();
    }

    public DbConnection GetConnection()
    {
        return _connection;
    }
}