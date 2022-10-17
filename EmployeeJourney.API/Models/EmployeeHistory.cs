namespace EmployeeJourney.API.Models;

public record EmployeeHistory(
    int id_employee_history,
    int id_employee,
    string position,
    DateTime create_on
);




