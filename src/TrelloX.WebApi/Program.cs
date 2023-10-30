using Serilog;

using TrelloX.Application;
using TrelloX.Infrastructure;
using TrelloX.WebApi;
using TrelloX.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddInfrastructure(builder.Configuration)
        .AddApplication();

    builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.ApplyMigrations();
    }
    app.UseExceptionHandler("/error");
    app.UseSerilogRequestLogging();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}