using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Payment.Test.Tuya.API.Common;
using Payment.Test.Tuya.API.Extension;
using Payment.Test.Tuya.DAL.Context;

namespace Payment.Test.Tuya.API
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        internal readonly string AllowSpecificOrigins = "CorsPolicy";
        private GeneralConfigurations _generalConfigurations;
        private SwaggerConfiguration _swaggerConfiguration;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddOptions();
            _generalConfigurations = Configuration.GetSection(nameof(GeneralConfigurations)).Get<GeneralConfigurations>();
            _swaggerConfiguration = Configuration.GetSection(nameof(SwaggerConfiguration)).Get<SwaggerConfiguration>();
            services.AddMvcCore().AddApiExplorer();

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ApplicationContext")));

            services.Configure<GeneralConfigurations>(
                Configuration.GetSection(nameof(GeneralConfigurations)));

            services.AddSingleton<IGeneralConfigurations>(gc =>
               gc.GetRequiredService<IOptions<GeneralConfigurations>>().Value);

            services.AddRazorPages();
            services.GeneralConfigurations();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(_swaggerConfiguration.DocName, new OpenApiInfo
                {
                    Version = _swaggerConfiguration.DocInfoVersion,
                    Title = _swaggerConfiguration.DocInfoTitle,
                    Description = _swaggerConfiguration.DocInfoDescription
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(_swaggerConfiguration.EndpointUrl, _swaggerConfiguration.EndpointDescription);
            });
        }
    }
}
