using BloodborneCharacterPlanner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodborneCharacterPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(e => e.Characters)
                .WithOne(e => e.Creator)
                .HasForeignKey(e => e.CreatorId)
                .HasPrincipalKey(e => e.Id);
        }

        public DbSet<BBCharacter> CharacterSet { get; set; } = default!;
    }
}