using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeinProfil.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<AppUser>()
        //        .Property(u => u.Address)
        //        .HasMaxLength(20);

        //    builder.Entity<AppUser>()
        //        .Property(u => u.Job)
        //        .HasMaxLength(100);

        //    builder.Entity<AppUser>()
        //        .Property(u => u.ProfilePicture)
        //        .HasMaxLength(50);
        //    builder.Entity<AppUser>()
        //        .Property(u => u.IdentityNumber)
        //        .HasMaxLength(50);
        //}
    }
}
