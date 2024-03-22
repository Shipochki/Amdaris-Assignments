using Amdaris.Logging;
using Amdaris.Logging.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the DI/IoC container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAmdarisLogging();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/di", (AmdarisLogger logger) =>
{
	logger.LogMessage("Hello, Amdaris! Logged using DI");
	return "Hello, Amdaris! Logged using DI";
});

app.MapGet("/sl", (IServiceProvider serviceProvider) =>
{
	var logger = serviceProvider.GetRequiredService<AmdarisLogger>();
	logger.LogMessage("Hello, Amdaris! Logged using SL", true);
	return "Hello, Amdaris! Logged using SL";
});

app.Run();
