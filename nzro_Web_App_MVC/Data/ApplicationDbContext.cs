using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nzro_Web_App_MVC.Models;

namespace nzro_Web_App_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<nzro_Web_App_MVC.Models.Joke>? Joke { get; set; }
    }
}