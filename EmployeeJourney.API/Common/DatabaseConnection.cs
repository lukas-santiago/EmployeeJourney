using MySql.Data.MySqlClient;

namespace EmployeeJourney.API.Common;

class DatabaseConnection
{
    private readonly IConfiguration _configuration;
    private readonly MySqlConnection _connection;
    public DatabaseConnection(IConfiguration configuration)
    {
        _configuration = configuration;
        _connection = new MySqlConnection(_configuration.GetConnectionString("SQLConnection"));
        _connection.Open();
    }

    public MySqlConnection GetConnection()
    {
        return _connection;
    }
}