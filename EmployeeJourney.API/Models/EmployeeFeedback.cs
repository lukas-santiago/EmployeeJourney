namespace EmployeeJourney.API.Models;

public record EmployeeFeedback(
    int id_employee_feedback,
    int id_employee,
    string author,
    string strengths,
    string minuses,
    string expected_actions,
    string goals,
    DateTime created_on
);