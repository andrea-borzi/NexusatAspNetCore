﻿using Nexusat.AspNetCore.Builders;
using Nexusat.AspNetCore.Configuration;
using Nexusat.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NexusatAspNetCoreMvcBuilderExtensions
    {
        /// <summary>
        /// Adds the nexusat ASP net core to the MVC pipeline.
        /// </summary>
        /// <returns>The MVC builder</returns>
        /// <param name="mvcBuilder">Mvc builder.</param>
        /// <param name="setupAction">Setup action.</param>
        public static IMvcBuilder AddNexusatAspNetCore(this IMvcBuilder mvcBuilder, Action<NexusatAspNetCoreOptionsBuilder> setupAction = null)
        {
            var builder = new NexusatAspNetCoreSystemBuilder(mvcBuilder, setupAction);

            builder
                .AddSystemService()
                .AddFrameworkServices();

            return mvcBuilder;
        }
    }
   
    
}
