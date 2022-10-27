using EmployeeJourney.API.Common;
using EmployeeJourney.API.Middlewares;
using EmployeeJourney.API.Repository;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddScoped<DatabaseConnection>();
    builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    builder.Services.AddScoped<IEmployeeFeedbackRepository, EmployeeFeedbackRepository>();
    builder.Services.AddScoped<IEmployeeJourneyMapRepository, EmployeeJourneyMapRepository>();
}
var app = builder.Build();
{
    //Middlewares
    app.UseMiddleware(typeof(GlobalErrorHandlerMiddleware));
}
{
    app.UseCors(builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
    );
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    // app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}