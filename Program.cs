using Microsoft.AspNetCore.Builder;
using NSwag.AspNetCore;
using TeamApi;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TeamApiDb;Trusted_Connection=True;"));


// Register NSwag OpenAPI document generation
builder.Services.AddOpenApiDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();    // Generates the OpenAPI/Swagger documentation
    app.UseSwaggerUi3(); // Serves Swagger UI
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
