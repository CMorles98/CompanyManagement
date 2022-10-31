using CompanyManagement.Domain.Logger;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Domain.Services;
using CompanyManagement.Domain.Services.Divisions;
using CompanyManagement.Domain.Services.Offices;
using CompanyManagement.Domain.Services.Positions;
using CompanyManagement.Domain.Services.Salaries;
using CompanyManagement.Domain.Shared.Validations;
using CompanyManagement.Domain.Shared.Validations.Base;
using CompanyManagement.Infrastructure.Data;
using CompanyManagement.Infrastructure.Logger;
using CompanyManagement.Infrastructure.Mapping;
using CompanyManagement.Infrastructure.Repositories;
using CompanyManagement.WebApi.ActionFilters;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CompanyManagement.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCorsConfiguration(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void AddIISConfiguration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => { });

        public static void AddLoggerServiceConfiguration(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void AddSqlServerConfiguration(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("SqlConnection"),
                b => b.MigrationsAssembly("CompanyManagement.Infrastructure")));

        public static void AddRepositoryManagerConfiguration(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void AddValidationFilterConfiguration(this IServiceCollection services) =>
            services.AddScoped<ValidationFilterAttribute>();

        public static void AddResponseCachingConfiguration(this IServiceCollection services) =>
            services.AddResponseCaching();

        public static void AddHttpCacheHeadersConfigration(this IServiceCollection services) =>
            services.AddHttpCacheHeaders(
             (expirationOpt) =>
             {
                 expirationOpt.MaxAge = 60;
                 expirationOpt.CacheLocation = CacheLocation.Private;
             },
             (validationOpt) =>
             {
                 validationOpt.MustRevalidate = true;
             });

        public static void AddApiVersioningConfiguration(this IServiceCollection services) =>
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });

        public static void AddSwaggerConfiguration(this IServiceCollection services) =>

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CompanyManagement.WebApi", Version = "v1" });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });
        public static void AddModelStateConfiguration(this IServiceCollection services) =>
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        public static void AddServicesConfigurations(this IServiceCollection services)
        {
            services.AddTransient<IDivisionServices, DivisionServices>();
            services.AddTransient<IOfficeServices, OfficeService>();
            services.AddTransient<IPositionServices, PositionServices>();
            services.AddTransient<ISalaryService, SalaryService>();
        }
        public static IServiceCollection AddValidatorsConfiguration(this IServiceCollection services) =>
            services.AddTransient<ISalaryValidator, SalaryValidator>();
    }
}
