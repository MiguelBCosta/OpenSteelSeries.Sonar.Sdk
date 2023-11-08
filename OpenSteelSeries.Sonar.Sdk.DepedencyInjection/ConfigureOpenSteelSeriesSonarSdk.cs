using Microsoft.Extensions.DependencyInjection;
using OpenSteelSeries.Sonar.Sdk.Implementation;
using OpenSteelSeries.Sonar.Sdk.Interfaces;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net;
using System.Net.Http;

namespace OpenSteelSeries.Sonar.Sdk.DepedencyInjection
{
    public static class ConfigureOpenSteelSeriesSonarSdk
    {
        public static IServiceCollection AddOpenSteelSeriesSonaServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddHttpClient<ISonarClassicVolumeSettingsService, SonarClassicVolumeSettingsService>()
               .AddPolicyHandler((services, request) => GetRetryPolicy<ISonarClassicVolumeSettingsService>(services));
            serviceCollection.AddHttpClient<ISonarStreamerVolumeSettingsService, SonarStreamerVolumeSettingsService>()
                 .AddPolicyHandler((services, request) => GetRetryPolicy<ISonarStreamerVolumeSettingsService>(services));
            serviceCollection.AddHttpClient<ISonarModeService, SonarModeService>()
                .AddPolicyHandler((services, request) => GetRetryPolicy<ISonarModeService>(services));
            return serviceCollection;
        }

        static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy<T>(IServiceProvider services) where T : ISonarClient
        {
            return HttpPolicyExtensions
                   .HandleTransientHttpError()
                   .OrResult(msg => msg.StatusCode == HttpStatusCode.NotFound)
                   .WaitAndRetryForeverAsync(retryAttempt => TimeSpan.FromSeconds(5), (exception, timespan, context) =>
                    {
                        var sonarClient = services.GetRequiredService<T>() as ISonarClient;
                        sonarClient.TryGetBaseUrl();
                    });
        }
    }
}
