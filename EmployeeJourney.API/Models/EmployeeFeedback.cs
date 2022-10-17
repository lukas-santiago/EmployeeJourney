namespace EmployeeJourney.API.Models;

public record EmployeeFeedback(
    int id_employee_feedback,
    int id_employee,
    string feedback,
    DateTime create_on
);




