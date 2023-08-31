using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SecondSalesApiDb.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SecondSalesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevDb") 
    ?? throw new InvalidOperationException("Connection string 'DevDb' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
