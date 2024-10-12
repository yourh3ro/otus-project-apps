using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapPost("/api/encryption/encrypt", async (HttpContext httpContext) =>
{
    using var reader = new System.IO.StreamReader(httpContext.Request.Body, Encoding.UTF8);
    var message = await reader.ReadToEndAsync();

    if (string.IsNullOrEmpty(message))
    {
        return Results.BadRequest("Message cannot be null or empty.");
    }

    var messageBytes = Encoding.UTF8.GetBytes(message);
    var base64Message = Convert.ToBase64String(messageBytes);

    return Results.Ok(base64Message);
});

app.MapGet("/health", () => "OK");

app.UseRouting();
app.Run("http://0.0.0.0:5000");
