namespace EmployeeJourney.API.Models;

public record EmployeeJourneyMap(
    int id_employee_journey,
    int id_employee,
    string job_position,
    decimal salary,
    DateTime date_start,
    DateTime date_end,
    string notes
);
