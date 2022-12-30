using BitkiDunyasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BitkiDunyasi.Migrations
{
    public class ApplicationDbContext : IdentityDbContext<UserDetail>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext(){}
        public DbSet<Bitki> Bitkiler { get; set; }
        public DbSet<Usercomment> Usercomments { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BitkilerDunyasi;Trusted_Connection=True;");
        }

    }
}