using ExploreCalifornia.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped(it => new FeatureToggle
            {
                DeveloperExceptions = configuration.GetValue<bool>("FeatureToggles:DeveloperExceptions")
            });

            services.AddDbContext<BlogDataContext>(
                options =>
                {
                    var connectionString = configuration.GetConnectionString("BlogConnectionString");
                    options.UseSqlServer(connectionString);
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FeatureToggle featureToggle)
        {
            if (featureToggle.DeveloperExceptions)
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/error.html");

            app.UseRouting();

            app.UseMvc(
                routes =>
                {
                    routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
                });

            app.UseFileServer();
            app.Use(async (context, next) =>
                {
                    if (context.Request.Path.Value.Contains("invalid"))
                    {
                        throw new Exception("ERROR!");
                    }

                    await next();
                });
        }
    }
}
