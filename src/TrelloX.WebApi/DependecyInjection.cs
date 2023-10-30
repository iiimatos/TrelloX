using Microsoft.AspNetCore.Mvc.Infrastructure;

using TrelloX.WebApi.Common.Errors;

namespace TrelloX.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddSingleton<ProblemDetailsFactory, TrelloXProblemDetailsFactory>();
        return services;
    }
}