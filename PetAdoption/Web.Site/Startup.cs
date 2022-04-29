using Web.Site.Controllers.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
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

