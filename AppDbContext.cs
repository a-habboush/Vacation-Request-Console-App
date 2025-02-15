

using Microsoft.EntityFrameworkCore;

namespace VacationRequestTask
{
	internal class AppDBContext : DbContext
	{


		// config

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);


			optionsBuilder.UseSqlServer("Server = DESKTOP-JA5749V; Database = Project1DB; Integrated Security = SSPI; TrustServerCertificate = True;");

		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//column constraints
			modelBuilder.Entity<Employee>()
				.HasCheckConstraint("check_vacationdays_limit", "remainingVacationDays <= 24");
		}


		// tables
		public DbSet<Department> Departments { get; set; } = null!;

		public DbSet<Position> Position { get; set; } = null!;

		public DbSet<Employee> Employee { get; set; } = null!;

		public DbSet<Vacation> Vacation { get; set; } = null!;

		public DbSet<RequestState> RequestState { get; set; } = null!;

		public DbSet<VacationRequest> VacationRequest { get; set; } = null!;




	}
}

