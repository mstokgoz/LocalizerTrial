using LocalizerTrial.Api;
using LocalizerTrial.Api.Localization;
using LocalizerTrial.Api.Modules;
using LocalizerTrial.Api.Modules.Handlers;
using LocalizerTrial.Api.Services.Test;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IFlightModuleHandler, FlightModuleHandler>();
builder.Services.RegisterLocalizationOptions();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterFlightEndpoints();
app.UseLocalization();

app.Run();

