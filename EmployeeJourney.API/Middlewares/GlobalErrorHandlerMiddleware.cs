using System.Net;
using System.Text.Json;
using EmployeeJourney.API.Common;

namespace EmployeeJourney.API.Middlewares;

internal class GlobalErrorHandlerMiddleware
{
    public RequestDelegate _next { get; }
    public GlobalErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(context, exception);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {

        HttpStatusCode status = HttpStatusCode.InternalServerError;
        string errorMessage = exception.Message;
        string stackTrace = exception.StackTrace == null ? "" : exception.StackTrace.ToString();

        if (exception is BaseException)
        {
            status = HttpStatusCode.BadRequest;
        }

        var result = JsonSerializer.Serialize(new { status, errorMessage , stackTrace });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 401;
        return context.Response.WriteAsync(result);
    }
}