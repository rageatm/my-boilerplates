using Jinrage78.Bar;
using Jinrage78.Foo;
using Microsoft.AspNetCore.Mvc.Formatters;
using NLog;
using NLog.Web;

LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Host.UseNLog();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddControllers(options =>
{
    Console.WriteLine("Default output formatters:");

    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;

        if (mediaFormatter == null)
        {
            Console.WriteLine($"  {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes
        {
            Console.WriteLine("  {0}, Media types: {1}",
              arg0: mediaFormatter.GetType().Name,
              arg1: string.Join(", ", mediaFormatter.SupportedMediaTypes));
        }
    }
});
builder.Services.AddSingleton<IBarService, BarService>().AddSingleton<IFooService, FooService>();
builder.Services.AddHealthChecks();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.UseHealthChecks(path: "/ping");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
