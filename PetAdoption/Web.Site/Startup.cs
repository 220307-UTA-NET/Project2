using Web.Site.Controllers.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using System;

//Note: In .NET 6 Microsoft has removed the Startup.cs class.
//Now when you'll add a connection string then you've to use builder.
//Services.AddDbContext The old way is services.AddDbContext

//Just use builder.Services and then you can achieve what you want.

namespace Web.Site

{
    public class Startup
    {
        public Startup(IConfigurationRoot configuration)
        {
            configuration = configuration;
        }

        public IConfigurationRoot Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
            //services.AddDbContext<MainDbContext>(contextOptions =>
            //{
            //    contextOptions.UseSqlServer(configuration.GetValue<string>(key: "ConnectionString"));
            //});

            //services.AddTransient(ISignalServuces, SignalServices);
            services.AddSignalR();

        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(x => x.MapControllers());
        }



        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

        public void ConfigurServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

        }

       }

  

        
    

    

using System;


namespace Web.Site
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
        services.AddDbContext<MainDbContext>(DbContextOptions =>
        {
            DbContextOptions.UseSqlServer(ConfigurationBinder.GetValue<string>(key: "ConnectionString"));
        });
    }

}

