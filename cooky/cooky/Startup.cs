using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace cooky
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddOpenTelemetryTracing((builder) => builder
            //    .AddAspNetCoreInstrumentation()
            //    .AddSqlClientInstrumentation(
            //        options => {
            //            options.SetDbStatementForText = true;
            //            options.RecordException = true;
            //            options.EnableConnectionLevelAttributes = true;
            //            options.Enrich = (activity, eventName, rawObject) =>
            //            {
            //                activity.IsAllDataRequested = true;
            //                if (eventName.Equals("OnCustom"))
            //                {
            //                    if (rawObject is SqlCommand cmd)
            //                    {
            //                        activity.SetTag("db.connection", cmd.Connection);
            //                        activity.SetTag("db.operation", cmd.CommandText.Split().FirstOrDefault());
            //                    }
            //                };
            //            };
            //        })
            //    .AddHttpClientInstrumentation(
            //        options => {
            //            options.SetHttpFlavor = true;
            //        })
            //    .SetSampler(new AlwaysOnSampler())
            //    .AddSource("httpserver.ProductController")
            //    .AddJaegerExporter(o =>
            //    {

            //    })
            //);
            services.AddControllers();
        }

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
        }
    }
}
