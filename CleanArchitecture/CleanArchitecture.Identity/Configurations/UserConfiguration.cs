using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "41dcf738-620d-40cc-8042-61558902d3a7",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "admin@localhost.com",
                    Nombre = "Vaxi",
                    Apellido = "Drez",
                    UserName = "vaxidrez",
                    NormalizedUserName = "vaxidrez",
                    PasswordHash = hasher.HashPassword(null,"VaxiDrez2025$")
                },
                new ApplicationUser
                {
                Id = "d1e4a646-150a-4cc4-a55d-39bd310dd82d",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "admin@localhost.com",
                    Nombre = "Juan",
                    Apellido = "Peres",
                    UserName = "juanperes",
                    NormalizedUserName = "juanperes",
                    PasswordHash = hasher.HashPassword(null, "VaxiDrez2025$")
                }

                );
        }
    }
}
