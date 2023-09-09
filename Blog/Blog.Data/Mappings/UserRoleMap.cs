using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(
                new AppUserRole
                {
                    UserId = Guid.Parse("182753C2-744C-4118-8179-2D7D03B588C9"),
                    RoleId = Guid.Parse("43801B55-5BEF-4234-80AB-8BA592DA48C9")
                },
                new AppUserRole
                {
                    UserId = Guid.Parse("1971A100-BB8B-4467-A652-829159A85C20"),
                    RoleId = Guid.Parse("FA8BB9E4-3F71-4C60-9C73-72384E405000")
                });
        }
    }
}
