using TrueRepApis.Application;
using System.Reflection;
using TrueRepApis.Infrastructure.Representatives;
using TrueRepApis.Configuration;
using TrueRepApis.Infrastructure.Sansad;
using TrueRepApis.Infrastructure.Common;





var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Application layer services
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IRepresentativesInfrastructure, RepresentativesInfrastructure>();
builder.Services.AddTransient<ISansadInfrastructure, SansadInfrastructure>();
builder.Services.AddTransient<EndpointResolver>();
builder.Services.AddTransient<ApiClient>();



builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var settings = new Settings();
builder.Configuration.Bind(settings);
builder.Services.AddSingleton(settings);

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
