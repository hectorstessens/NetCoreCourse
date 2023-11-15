global using System.Text;

using NetCoreCourse.CleanCodeDesignPatterns.Services;
using NetCoreCourse.CleanCodeDesignPatterns.Services.City;
using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPronosticoTiempoService, PronosticoTiempoService>();

builder.Services.AddTransient<IPronosticoTiempoService, PronosticoTiempoService>();
builder.Services.AddTransient<ITsunamiService, TsunamiService>();
builder.Services.AddTransient<ITerremotoService, TerremotoService>();
builder.Services.AddTransient<IPronosticoTiempoFactory, PronosticoTiempoFactory>();
builder.Services.AddTransient<ITsunamiProbabilityCalculatorBuilder, TsunamiProbabilityCalculatorBuilder>();

builder.Services.AddTransient(m => new TiempoBuenosAires());
builder.Services.AddTransient(m => new TiempoRosario());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
