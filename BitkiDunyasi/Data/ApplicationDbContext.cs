using BitkiDunyasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BitkiDunyasi.Data
{
	public class ApplicationDbContext : IdentityDbContext<UserDetails>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Bitki> Bitki { get; set; }
		public DbSet<Usercomment> Usercomment { get; set; }
		public DbSet<UserDetails> UserDetails { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BitkilerDunyasi;Trusted_Connection=True;");
		}
	}
}