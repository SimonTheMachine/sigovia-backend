using Microsoft.EntityFrameworkCore;
using sigovia_backend.api.Data;
using sigovia_backend.api.Interfaces;
using sigovia_backend.api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


DotNetEnv.Env.Load();
// Retrieve the connection string from the environment variable
var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IBookingRepository, BookingRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
// Normally this part would only be exposed in development using app.Environment.IsDevelopment()
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(x => x
     .AllowAnyMethod()
     .AllowAnyHeader()
     .AllowCredentials()
      //.WithOrigins("https://localhost:44351))
      .SetIsOriginAllowed(origin => true));


app.UseHttpsRedirection();

app.MapControllers();

app.Run();