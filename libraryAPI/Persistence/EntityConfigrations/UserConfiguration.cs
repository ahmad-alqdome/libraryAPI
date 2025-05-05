using libraryAPI.Const;
using libraryAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace libraryAPI.Persistence.EntityConfigrations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.FullName).HasMaxLength(100);


            builder.HasData(new ApplicationUser
            {
                Id = DefaultUsers.Admin.Id,
                FullName = "System Admin",
                UserName = DefaultUsers.Admin.Username,
                NormalizedUserName = DefaultUsers.Admin.Username.ToUpper(),
                Email = "admin@qdome.com",
                NormalizedEmail = "admin@qdome.com".ToUpper(),
                SecurityStamp = DefaultUsers.Admin.SecurityStamp,
                ConcurrencyStamp = DefaultUsers.Admin.ConcurrencyStamp,
                EmailConfirmed = true,
                PasswordHash = DefaultUsers.Admin.PasswordHash
            });
        }
    }
}
