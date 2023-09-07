using EventManager.Application.Interfaces;
using EventManager.Filters;
using EventManager.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EventManager", Version = "v1" });
});

builder.Services.AddDbContext<RegistrationDbContext>(options =>
       options.UseSqlServer(connectionString));

builder.Services.AddScoped<IEventLogRepository, EventLogRepository>();

builder.Services.AddControllers(options =>
{
    options.Filters.Add(new CustomExceptionFilter());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
