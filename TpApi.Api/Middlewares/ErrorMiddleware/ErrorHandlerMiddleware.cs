using System.Net;
using System.Text.Json;
using TpApi.Api.Middlewares.ErrorMiddleware.Responses;
using TpApi.Business.Contracts.Exceptions;

namespace TpApi.Api.Middlewares.ErrorMiddleware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception thrownException)
        {
            await HandleExceptionAsync(httpContext, thrownException);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception thrownException)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)GetHttpStatusCodeByException(thrownException);

        await context.Response.WriteAsync(JsonSerializer.Serialize(new ErrorResponse(thrownException)));
    }

    private HttpStatusCode GetHttpStatusCodeByException(Exception thrownException)
    {
        return thrownException switch
        {
            NotFoundException => HttpStatusCode.NotFound,
            BadRequestException => HttpStatusCode.NotFound,
            _ => HttpStatusCode.InternalServerError
        };
    }
}