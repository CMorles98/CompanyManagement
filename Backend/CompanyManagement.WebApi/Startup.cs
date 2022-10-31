using CompanyManagement.Domain.Logger;
using CompanyManagement.Infrastructure.Mapping;
using CompanyManagement.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompanyManagement.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCorsConfiguration();

            services.AddIISConfiguration();

            services.AddLoggerServiceConfiguration();

            services.AddSqlServerConfiguration(Configuration);

            services.AddRepositoryManagerConfiguration();

            services.AddServicesConfigurations();

            services.AddValidationFilterConfiguration();

            services.AddResponseCachingConfiguration();

            services.AddHttpCacheHeadersConfigration();

            services.AddApiVersioningConfiguration();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddSwaggerConfiguration();

            services.AddModelStateConfiguration();

            services.AddValidatorsConfiguration();


            services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
                config.CacheProfiles.Add("120SecondsCache", new CacheProfile { Duration = 120 });
            });
              //  .AddJsonOptions(x =>
              //x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CompanyManagement.WebApi v1"));
            }
            else
            {
                app.UseHsts();
            }

            app.UseExceptionHandlerConfiguration(logger);

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseResponseCaching();

            app.UseHttpCacheHeaders();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
