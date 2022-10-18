namespace EmployeeJourney.API.Models;

public record Employee(
    int id_employee,
    string username,
    string first_name,
    string last_name,
    string email,
    string phone,
    string gender,
    string address,
    string department,
    string password,
    string about
);