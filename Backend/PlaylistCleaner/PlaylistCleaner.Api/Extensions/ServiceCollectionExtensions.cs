﻿using PlaylistCleaner.ApiClients.Clients.SpotifyApiClient;
using Hellang.Middleware.ProblemDetails;
using PlaylistCleaner.Api.Exceptions;
using PlaylistCleaner.ApiClients.Clients.ApiClient;

namespace PlaylistCleaner.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddControllers()
            .AddApplicationPart(typeof(ServiceCollectionExtensions).Assembly);
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddProblemDetails(o =>
        {
            o.OnBeforeWriteDetails = (_, details) => details.Type = null;
            o.MapToStatusCode<TokenNotFoundException>(StatusCodes.Status401Unauthorized);
        });
        
        services.AddHttpClient<IApiClient, ApiClient>();
        services.AddTransient<ISpotifyApiClient, SpotifyApiClient>();

        return services;
    }
}
