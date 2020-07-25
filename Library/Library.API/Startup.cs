using AutoMapper;
using Library.API.Entities;
using Library.API.Helpers;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Library.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appSettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(
                action =>
                {
                    action.ReturnHttpNotAcceptable = true;
                    action.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                    action.InputFormatters.Add(new XmlDataContractSerializerInputFormatter());
                });

            var connectionString = Configuration["connectionStrings:libraryDBConnectionString"];
            services.AddDbContext<LibraryContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<ILibraryRepository, LibraryRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, LibraryContext libraryContext)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler(
                    appBuilder =>
                    {
                        appBuilder.Run(
                            async context =>
                            {
                                context.Response.StatusCode = 500;
                                await context.Response.WriteAsync("An unexpected fault happened. Please try again later");
                            });
                    });

            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<AuthorEntity, AuthorDto>()
                       .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                       .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
                    cfg.CreateMap<AuthorForCreationDto, AuthorEntity>();
                    cfg.CreateMap<BookEntity, BookDto>();
                    cfg.CreateMap<BookForCreationDto, BookEntity>();
                    cfg.CreateMap<BookForUpdateDto, BookEntity>();
                    cfg.CreateMap<BookEntity, BookForUpdateDto>();
                });

            libraryContext.EnsureSeedDataForContext();

            app.UseMvc();
        }

        //

        private readonly IConfigurationRoot Configuration;
    }
}
