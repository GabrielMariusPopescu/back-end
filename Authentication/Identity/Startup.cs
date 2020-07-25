using Identity.Entitites;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Identity
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddDbContext<AppDbContext>(config =>
			{
				config.UseInMemoryDatabase("Memory");
			});

			services.AddIdentity<IdentityUser, IdentityRole>(config =>
				{
					config.Password.RequiredLength = 4;
					config.Password.RequireNonAlphanumeric = false;
					config.Password.RequireUppercase = false;
					config.Password.RequireLowercase = false;
				})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();

			services.ConfigureApplicationCookie(config =>
			{
				config.Cookie.Name = "Identity.Cookie";
				config.LoginPath = "/Home/Login";
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
