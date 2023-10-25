using NetCoreCourse.CleanCodeDesignPatterns.Services;
using NetCoreCourse.CleanCodeDesignPatterns.Services.City;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IWeatherForeCastService, WeatherForeCastService>();
builder.Services.AddTransient<IWeatherForeCastFactory, WeatherForeCastFactory>();
builder.Services.AddTransient(m => new WeatherBuenosAires());
builder.Services.AddTransient(m => new WeatherRosario());
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
