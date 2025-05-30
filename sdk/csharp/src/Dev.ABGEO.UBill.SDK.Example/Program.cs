using System;
using System.Threading.Tasks;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dev.ABGEO.UBill.SDK.Example;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        var api = host.Services.GetRequiredService<ISmsApi>();
        var apiResponse = await api.GetBalanceAsync(null);
        var model = apiResponse.Ok();

        Console.WriteLine(apiResponse.RawContent);
        Console.WriteLine(model?.ToString());
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureApi((_, _, options) =>
            {
                // the type of token here depends on the api security specifications
                ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Key, "");
                options.AddTokens(token);

                // optionally choose the method the tokens will be provided with, default is RateLimitProvider
                options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

                options.ConfigureJsonOptions(jsonOptions =>
                {
                    // your custom converters if any
                });

                options.AddApiHttpClients(builder: builder => builder
                        .AddRetryPolicy(2)
                        .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                        .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                    // add whatever middleware you prefer
                );
            });
    }
}