using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Basic
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", config =>
				{
					config.Cookie.Name = "Grandmas.Cookie";
					config.LoginPath = "/Home/Authenticate";
				});

			services.AddAuthorization(config =>
			{
				var defaultAuthBuilder = new AuthorizationPolicyBuilder();
				var defaultAuthPolicy = defaultAuthBuilder.RequireAuthenticatedUser().RequireClaim(ClaimTypes.DateOfBirth).Build();
				config.DefaultPolicy = defaultAuthPolicy;
			});
			services.AddControllersWithViews();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
		}
	}
}
