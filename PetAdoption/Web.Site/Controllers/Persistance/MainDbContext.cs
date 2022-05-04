using System;

using Microsoft.EntityFrameworkCore;

namespace Web.Site.Controllers.Persistance
{
	public class MainDbContext : DbContext
	{
		public MainDbContext(DbContextOptions<MainDbContext> options): base(options)
		{
			
		}

		public DbSet<SignalDataModel> Signals { get; set; }


namespace Web.Site.Controllers.Persistance
{
	public class MainDbContext
	{
		public MainDbContext()
		{
		}

	}
}

