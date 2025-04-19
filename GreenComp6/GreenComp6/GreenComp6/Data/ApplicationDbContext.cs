//Name: Daria Green
//Email: Dgreen50@cnm.edu
//File: ApplicationDbContext.cs

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


}
