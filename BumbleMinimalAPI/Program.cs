using BumbleDataAccess.Data;
using BumbleMinimalAPI.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IGoatData, GoatData>();
builder.Services.AddSingleton<IFarmerData, FarmerData>();
builder.Services.AddSingleton<IDairyData, DairyData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureGoatApi();
app.ConfigureFarmerApi();
app.ConfigureDairyApi();

app.Run();