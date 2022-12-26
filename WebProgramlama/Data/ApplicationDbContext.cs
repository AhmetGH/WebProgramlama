using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebProgramlama.Models;

namespace WebProgramlama.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDetails>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}