using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(exceptionHandlerApp =>
{
    exceptionHandlerApp.Run(async context =>
    {
        context.Response.ContentType = Application.Json;

        var exceptionHandlerPathFeature =
            context.Features.Get<IExceptionHandlerPathFeature>();

        object body;

        if (exceptionHandlerPathFeature?.Error is ArgumentException)
        {
            context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            body = new
            {
                statusCode = context.Response.StatusCode,
                message = exceptionHandlerPathFeature.Error.Message
            };
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            body = new
            {
                statusCode = context.Response.StatusCode,
                message = "An exception was thrown."
            };
        }

        await context.Response.WriteAsync(JsonSerializer.Serialize(body));
    });
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
