using CityInfoAPI.Interfaces;
using CityInfoAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<IDawaService, DawaService>( client =>
{
    client.BaseAddress = new Uri("https://api.dataforsyningen.dk");
});

builder.Services.AddHttpClient<IWikipediaService, WikiapediaService>( client =>
{
    client.BaseAddress = new Uri("https://da.wikipedia.org/w/api.php");
});


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