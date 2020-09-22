using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DAL.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ToolBoxDB;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<DbProviderFactory>(sp => SqlClientFactory.Instance);
            services.AddSingleton(sp => new ConnectionStringObj(@"Data Source=(localdb)\MSSQLLocalDB;
                                                                Initial Catalog = NamurTourismeDB; 
                                                                Integrated Security = True"));
            services.AddSingleton<Connection>();
            services.AddSingleton<AdresseRepository>();
            services.AddSingleton<PlanningRepository>();
            services.AddSingleton<ThemeRepository>();
            services.AddSingleton<TypeThemeRepository>();
            services.AddSingleton<UtilisateurRepository>();
            services.AddSingleton<AvisRepository>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "AccessGranted",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseRouting();

            app.UseCors("AccessGranted");
        }
    }
}
