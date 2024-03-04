using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetEMG2.Models;

namespace ProjetEMG2.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<Car> Cars { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define your database schema and relationships here

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            // Define roles
            string adminRoleName = "Admin";
            string userRoleName = "User";

            Guid AdminRoleId = Guid.NewGuid();
            Guid UserRoleId = Guid.NewGuid();

            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = AdminRoleId.ToString(), Name = adminRoleName, NormalizedName = adminRoleName.ToUpper() },
                new IdentityRole { Id = UserRoleId.ToString(), Name = userRoleName, NormalizedName = userRoleName.ToUpper() }
            );

            // Seed default users with roles
            IdentityUser admin = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@example.com",
                // Add other properties as needed
            };

            admin.PasswordHash = hasher.HashPassword(admin, "P@ssword1234");

            modelBuilder.Entity<IdentityUser>().HasData(admin);

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = AdminRoleId.ToString() }
            );

            IdentityUser user1 = new IdentityUser
            {
                UserName = "user1",
                Email = "user1@example.com",
                // Add other properties as needed
            };

            user1.PasswordHash = hasher.HashPassword(user1, "P@ssword1234");

            modelBuilder.Entity<IdentityUser>().HasData(user1);

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = user1.Id, RoleId = UserRoleId.ToString() }
            );
        }
    }
}
