using Finnotech.Abstractions;
using Finnotech.Abstractions.Card;
using Finnotech.Abstractions.Facility;
using Finnotech.Abstractions.Oak;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Net.Http;

namespace Finnotech.Extensions.Microsoft.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFinnotech(this IServiceCollection services, FinnotechClientOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            services.AddSingleton(serviceProvider => GetService<ICardService>(options));
            services.AddSingleton(serviceProvider => GetService<IFacilityService>(options));
            services.AddSingleton(serviceProvider => GetService<IOakService>(options));
            services.AddSingleton<IFinnotechClient, FinnotechClient>();
        }

        public static void AddFinnotechUseApiBeta(this IServiceCollection services)
        {
            services.AddFinnotech(FinnotechClientOptions.ApiBeta);
        }

        public static void AddFinnotechUseSandboxBeta(this IServiceCollection services)
        {
            services.AddFinnotech(FinnotechClientOptions.SandboxBeta);
        }

        private static TService GetService<TService>(FinnotechClientOptions options)
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri(options.BaseUrl)
            };

            return RestService.For<TService>(httpClient);
        }
    }
}
