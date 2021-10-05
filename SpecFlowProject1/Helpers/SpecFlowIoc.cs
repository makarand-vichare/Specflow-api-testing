using BoDi;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using WebApplication2;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using SpecFlowProject1.Filters;

namespace SpecFlowProject1.Helpers
{
    public class SpecFlowIoc
    {

        private static ObjectContainer _container;
        public static void Initialize()
        {
            var apiUrl = TestConfig.TestConfiguration.GetValue<string>("ApiUrl");

            var container = new ObjectContainer();
            container.RegisterInstanceAs(GetFactory(apiUrl, attachUser: true), "httpClientWithUser1");
            container.RegisterInstanceAs(GetFactory(apiUrl, attachUser: false), "httpClientWithUser2");
            _container = container;
        }

        public static T GetInstance<T>() where T : class
        {
            return _container.Resolve<T>();
        }
        public static T GetInstance<T>(string name) where T : class
        {
            return _container.Resolve<T>(name);
        }

        private static HttpClient GetFactory(string apiUrl, bool attachUser)
        {
            return new WebApplicationFactory<Startup>()
                 .WithWebHostBuilder(builder =>
                 {
                     builder.UseEnvironment(TestConfig.TestEnviornmentName);
                     builder.ConfigureAppConfiguration((context, configBuilder) =>
                     {
                         configBuilder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appOverrideSettings.json"));
                         TestConfig.ApiConfiguration = configBuilder.Build();
                     });

                     builder.ConfigureTestServices(services =>
                     {
                         services.AddMvc(options =>
                         {
                             options.Filters.Add(new AttachFakeUser(attachUser ? TestConfig.ValidTestUser : TestConfig.InValidTestUser));
                         });
                     });

                 })
                 .CreateClient(new WebApplicationFactoryClientOptions {
                  BaseAddress = new Uri(apiUrl)
                 });
        }
    }
}
