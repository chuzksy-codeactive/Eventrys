using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventrys.Src.Data;
using Eventrys.Src.Domain.Validators;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Eventrys
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
            services.AddDbContext<EventrysDBContext>
                (opt => opt.UseSqlServer (Configuration["Data:EventrysConnection:ConnectionString"]));

            services.AddMvc (options =>
                {
                    options.EnableEndpointRouting = false;
                    options.Filters.Add<ValidationFilter> ();
                })
                .SetCompatibilityVersion (CompatibilityVersion.Version_3_0)
                .AddFluentValidation (config => config.RegisterValidatorsFromAssemblyContaining<Startup> ());;

            services.AddControllers()
                .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
