using CompanyManagement.Domain.Logger;
using CompanyManagement.Domain.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CompanyManagement.WebApi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void UseExceptionHandlerConfiguration(this IApplicationBuilder app, ILoggerManager logger) =>
            app.UseExceptionHandler(error =>
                error.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Something went wrong with {contextFeature.Error}");

                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = (int)HttpStatusCode.InternalServerError,
                            Message = "Internal server error."
                        }.ToString());
                    }
                }));
    }
}
