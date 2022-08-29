using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "11c34c14-b2ab-4822-9325-27911109efca",
                    UserId = "41dcf738-620d-40cc-8042-61558902d3a7"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "152a1077-befd-40e4-9b49-baa959d3328e",
                    UserId = "d1e4a646-150a-4cc4-a55d-39bd310dd82d"
                }
                );
        }
    }
}
