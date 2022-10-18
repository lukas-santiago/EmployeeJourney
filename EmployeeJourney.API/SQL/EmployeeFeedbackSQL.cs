namespace EmployeeJourney.API.SQL;
internal sealed class EmployeeFeedbackSQL
{
    public static readonly string SELECT_ALL =
        @"SELECT TOP (1000) * FROM [employee_journey_map].[dbo].[employee_feedback]";
    public static readonly string SELECT =
        @"SELECT TOP (1) * FROM [employee_journey_map].[dbo].[employee_feedback]
          WHERE id_employee_feedback = @id_employee_feedback";
    public static readonly string INSERT =
        @"INSERT INTO [employee_journey_map].[dbo].[employee_feedback]
            ([id_employee],[author],[strengths],[minuses],[expected_actions],[goals],[created_on])
          VALUES (@id_employee,@author,@strengths,@minuses,@expected_actions,@goals,@created_on)";
    public static readonly string UPDATE =
        @"UPDATE [employee_journey_map].[dbo].[employee_feedback] 
          SET [id_employee]=@id_employee,[author]=@author,[strengths]=@strengths,[minuses]=@minuses,[expected_actions]=@expected_actions,[goals]=@goals,[created_on]=@created_on
          WHERE id_employee_feedback = @id_employee_feedback";
    public static readonly string DELETE =
        @"DELETE FROM [employee_journey_map].[dbo].[employee_feedback]
          WHERE id_employee_feedback = @id_employee_feedback";
}