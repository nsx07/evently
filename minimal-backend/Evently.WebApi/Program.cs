using Evently.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.Setup();

var app = builder.Build();

app.MapControllers();

app.MapOpenApi();

app.UseHttpsRedirection();

app.UseRouting();

app.Run();
