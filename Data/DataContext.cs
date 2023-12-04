global using Microsoft.EntityFrameworkCore;

namespace SuperHerosApi.Data
{

	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.//SQLExpress;Database=superheroes;Trusted_Connection=true;TrustServicerCertificate=true;"); // SQL Express DB connection connected to the Superheroes table.
		}

		public DbSet<SuperHero> SuperHeroes { get; set; }

	}
}