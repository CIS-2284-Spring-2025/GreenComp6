using GreenComp6.Components.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;



namespace GreenComp6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Asset> Asset { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;

        //public class ApplicationUser : IdentityUser
        //{
        //    // Add any custom properties here if needed
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }
    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source = data.db");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

    //TODO: You need DbSets for your models here. RJG
    //public DbSet<T> NameOfYourModelPluralized { get; set; } 

    //TODO: You will also need a web API controller in the server, a DAL that accesses the database directly in the server and a DAL that uses the web API controller in the client. RJG
}
