using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HSoG.Portal.Data
{
    public class AppDB : IdentityDbContext<User, Role, int>
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName).IsRequired().IsUnicode(false);
                entity.Property(e => e.NormalizedUserName).IsRequired().IsUnicode(false);
                entity.Property(e => e.Email).IsRequired().IsUnicode(false);
                entity.Property(e => e.NormalizedEmail).IsRequired().IsUnicode(false);
                entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(256).IsUnicode(false);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(250).IsUnicode(false).HasDefaultValueSql("('')");

                entity.HasData(new User
                {
                    Id = 1,
                    FullName = "Host Account",
                    UserName = "host",
                    NormalizedUserName = "HOST",
                    Email = "support@clearwox.com",
                    NormalizedEmail = "SUPPORT@CLEARWOX.COM",
                    AccessFailedCount = 0,
                    EmailConfirmed = true,
                    LockoutEnabled = true,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    PasswordHash = "AQAAAAEAACcQAAAAECQvPNb43OCmnOTgI+0vIUlYKHiaeb86CAkOiC6cqgnw63KGA0akaDtIMS8AeZ/UEg==",
                    SecurityStamp = "UNGTKDF5EN5BRYOMVKQ5DQ6ZGRTZLHYK",
                    ConcurrencyStamp = "01577897-c74f-4339-8eus-5d7b9b15f684",
                    PhoneNumber = "+234 1 279 9880"
                });

                entity.HasData(new User
                {
                    Id = 2,
                    FullName = "Adminmistrator",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@HSoG.Portalinstrars.com",
                    NormalizedEmail = "ADMIN@HSoG.PortalINSTRARS.COM",
                    AccessFailedCount = 0,
                    EmailConfirmed = true,
                    LockoutEnabled = true,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    PasswordHash = "AQAAAAEAACcQAAAAECQvPNb43OCmnOTgI+0vIUlYKHiaeb86CAkOiC6cqgnw63KGA0akaDtIMS8AeZ/UEg==",
                    SecurityStamp = "UNGTKDF5EN5BRYOMVKQ5DQ6ZGRTZLHYK",
                    ConcurrencyStamp = "01577897-c74f-4339-b368-5d7b9b15f684",
                    PhoneNumber = "+234 1 279 9880"
                });
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasData(new Role { Id = 1, Name = "admin", NormalizedName = "ADMIN", ConcurrencyStamp = "1bfa7a25-b1a2-42f0-bccf-a4a87f5e82is" });
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasData(new UserRole { UserId = 1, RoleId = 1 });
                entity.HasData(new UserRole { UserId = 2, RoleId = 1 });
            });
        }
    }
}