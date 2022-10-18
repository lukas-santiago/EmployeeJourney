namespace EmployeeJourney.API.Models;

// public record EmployeeHistory(
//     int id_employee_history,
//     int id_employee,
//     string position,
//     DateTime create_on
// );

public record EmployeeHistory(
    int id_employee_journey,
    int id_employee,
    string job_position,
    decimal salary,
    DateTime date_start,
    DateTime date_end,
    string notes
);
