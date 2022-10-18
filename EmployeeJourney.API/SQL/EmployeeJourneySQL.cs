namespace EmployeeJourney.API.SQL;
internal sealed class EmployeeJourneyMapSQL
{
    public static readonly string SELECT_ALL =
        @"SELECT TOP (1000) * FROM [employee_journey_map].[dbo].[employee_journey]";
    public static readonly string SELECT =
        @"SELECT TOP (1000) * FROM [employee_journey_map].[dbo].[employee_journey]
          WHERE id_employee_journey = @id_employee_journey";
    public static readonly string INSERT =
        @"INSERT INTO [employee_journey_map].[dbo].[employee_journey]
            ([id_employee],[job_position],[salary],[date_start],[date_end],[notes])
          VALUES (@id_employee,@job_position,@salary,@date_start,@date_end,@notes)";
    public static readonly string UPDATE =
        @"UPDATE [employee_journey_map].[dbo].[employee_journey] 
          SET [id_employee]=@id_employee ,[job_position]=@job_position ,[salary]=@salary ,[date_start]=@date_start ,[date_end]=@date_end ,[notes]=@notes
          WHERE id_employee_journey = @id_employee_journey";
    public static readonly string DELETE =
        @"DELETE FROM [employee_journey_map].[dbo].[employee_journey]
          WHERE id_employee_journey = @id_employee_journey";
}