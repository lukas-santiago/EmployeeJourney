namespace EmployeeJourney.API.SQL;
internal sealed class EmployeeSQL
{
    public static readonly string SELECT_ALL =
        @"SELECT * FROM employee";
    public static readonly string SELECT =
        @"SELECT TOP (1) *
          FROM [employee_journey_map].[dbo].[employee]
          WHERE id_employee = @id_employee";
    public static readonly string INSERT =
        @"INSERT INTO [employee_journey_map].[dbo].[employee]
            ([username],[first_name],[last_name],[email],[phone],[gender],[address],[department],[password],[about])
          VALUES (@username,@first_name,@last_name,@email,@phone,@gender,@address,@department,@password,@about)";
    public static readonly string UPDATE =
        @"UPDATE [employee_journey_map].[dbo].[employee] 
          SET [username]=@username ,[first_name]=@first_name ,[last_name]=@last_name ,[email]=@email ,[phone]=@phone ,[gender]=@gender ,[address]=@address ,[department]=@department ,[password]=@password ,[about]=@about
          WHERE id_employee = @id_employee";
    public static readonly string DELETE =
        @"DELETE FROM [employee_journey_map].[dbo].[employee]
          WHERE id_employee = @id_employee";
}