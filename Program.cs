using EightToTen.Service.GuessIt;
using EightToTen.Service.MagicBall;
using EightToTen.Service.Restaurant;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();
builder.Services.AddScoped<IGuessItService, GuessItService>();
builder.Services.AddScoped<IMagicBallService, MagicBallService>();

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
