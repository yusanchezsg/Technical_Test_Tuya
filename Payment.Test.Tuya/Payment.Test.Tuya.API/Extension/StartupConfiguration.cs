using Microsoft.Extensions.DependencyInjection;

namespace Payment.Test.Tuya.API.Extension
{
    public static class StartupConfiguration
    {
        public static readonly string MyAllowSpecificOrigins = "CorsPolicy";
        /// <summary>
        /// Method to add general configuration
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        public static void GeneralConfigurations(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                  builder =>
                  {
                      builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .WithMethods("GET")
                      .WithMethods("POST")
                      .WithMethods("PUT")
                      .WithMethods("DELETE")
                      .AllowAnyOrigin()
                      .AllowAnyHeader()
                      .SetIsOriginAllowed((host) => true)
                      .AllowAnyHeader();
                  });
            });
        }
    }
}
