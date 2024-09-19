// Add services to the container.
using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();





// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
