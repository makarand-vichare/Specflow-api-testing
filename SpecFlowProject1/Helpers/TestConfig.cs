using Microsoft.Extensions.Configuration;
using System;

namespace SpecFlowProject1.Helpers
{
    public static class TestConfig
    {
        public const string ValidTestUser = "ValidTestUser1";
        public const string InValidTestUser = "InValidTestUser1";
        public static IConfiguration TestConfiguration { get; set; }
        public static IConfiguration ApiConfiguration { get; set; }
        public static string TestEnviornmentName { get; set; }
        public static void LoadSettings()
        {
            string enviornmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIORNMENT");
            var testConfig = new ConfigurationBuilder()
                .AddJsonFile("integrationsettings.json")
                .AddJsonFile($"integrationsettings.{enviornmentName}.json")
                .Build();

            TestConfiguration = testConfig;
            TestEnviornmentName = enviornmentName;
        }
        public static void ClearSettings()
        {
            TestEnviornmentName = null;
            ApiConfiguration = null;
            TestConfiguration = null;
        }
    }
}
