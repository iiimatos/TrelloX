using Serilog;

using TrelloX.Application;
using TrelloX.Infrastructure;
using TrelloX.WebApi;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure()
        .AddWebApi();
    builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseSerilogRequestLogging();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}