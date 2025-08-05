using BudgetPal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetPal.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
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

        }

    }
}
