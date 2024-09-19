using BuberDinner.Application;
using BuberDinner.Infrastructure;
using BuberDinner.Presentation.Filters;
using BuberDinner.Presentation.Middlewares;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
// builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());





// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseExceptionHandler("/error");
// app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
