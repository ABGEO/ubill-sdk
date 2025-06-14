/*
 * UBill API
 *
 * UBill API - provides programmatic access to our resources. You will be able to integrate our service into your system and communicate with clients easily.
 *
 * The version of the OpenAPI document: 2.1.7
 * Contact: info@ubill.ge
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Extensions;
using Xunit;

namespace Dev.ABGEO.UBill.SDK.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Key, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Key, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Key, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Key, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var smsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ISmsApi>();
            Assert.True(smsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var smsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ISmsApi>();
            Assert.True(smsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var smsApi = _hostUsingAddWithAClient.Services.GetRequiredService<ISmsApi>();
            Assert.True(smsApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var smsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ISmsApi>();
            Assert.True(smsApi.HttpClient.BaseAddress != null);
        }
    }
}
