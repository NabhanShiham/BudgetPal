using BudgetPal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BudgetPal.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FriendRequest>()
                .HasOne(fr => fr.FromUser)
                .WithMany()
                .HasForeignKey(fr => fr.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<FriendRequest>()
                .HasOne(fr => fr.ToUser)
                .WithMany()
                .HasForeignKey(fr => fr.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasOne(u => u.UserProfile)
                .WithOne(p => p.User)
                .HasForeignKey<UserProfile>(p => p.ApplicationUserId);


            builder.Entity<UserProfile>()
                    .HasOne(up => up.User)
                    .WithMany()
                    .HasForeignKey(up => up.ApplicationUserId);



        }

    }
}
