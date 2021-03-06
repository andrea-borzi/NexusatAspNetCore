﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nexusat.AspNetCore.Models;
using Nexusat.AspNetCore.Mvc.Formatters;

namespace Nexusat.AspNetCore.Implementations
{
    /// <summary>
    /// Manage all the status code pages generated by the MVC framework
    /// </summary>
    internal class InternalStatusCodePagesOptions: StatusCodePagesOptions
    {
        public InternalStatusCodePagesOptions()
        {
            HandleAsync = (ctx) =>
            {
                var services = ctx.HttpContext.RequestServices;
                var executor = services.GetRequiredService<ApiResponseExecutor>();

                var httpStatusCode = ctx.HttpContext.Response.StatusCode;
                ApiResponse response = null; 
                if ( httpStatusCode == 404)
                {
                    response = new NotFoundResponse();
                } else {
                    response = new ApiResponse();
                    response.Status.HttpCode = httpStatusCode;
                    response.Status.Code = string.Format("{0}_{1}_UNMANAGED", StatusCode.KO, httpStatusCode);
                }

                executor.RenderResponse(ctx.HttpContext, response);

                return Task.FromResult(0);
            };
        }
    }
}
