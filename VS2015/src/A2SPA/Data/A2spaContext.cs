using A2SPA.Models;
using A2SPA.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace A2SPA.Data
{
    public class A2spaContext : IdentityDbContext<ApplicationUser>
    {
        public A2spaContext(DbContextOptions<A2spaContext> options) : base(options)
        {
        }

        public DbSet<TestData> TestData { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Need> Need { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TestData>().ToTable("TestData");
            base.OnModelCreating(modelBuilder);
        }
    }
}
