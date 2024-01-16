using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using TpApi.Api.Extensions;
using TpApi.Api.Middlewares.ErrorMiddleware;
using TpApi.Business.Extensions;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApi()
        .AddBusiness()
        .AddRepositories(builder.Configuration);

    builder.Services
        .AddControllers()
        .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        // Set the comments path for the Swagger JSON and UI.
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });

}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<ErrorHandlerMiddleware>();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
}

app.Run();
