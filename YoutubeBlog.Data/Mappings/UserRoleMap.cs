using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("E5102E42-2326-40D7-AE9D-F6593CE92A48"),
                RoleId = Guid.Parse("354043D3-5934-4136-B117-99F57B40F0F7")
            }, new AppUserRole
            {
                UserId = Guid.Parse("45D910AF-E957-4880-88A7-49B1FCED6D24"),
                RoleId = Guid.Parse("9E62CBD1-68E7-4A37-BDB6-844C6C8090E3")
            });
        }
    }
}
