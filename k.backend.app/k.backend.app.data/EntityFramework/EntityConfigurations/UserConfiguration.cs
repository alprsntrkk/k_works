using k.backend.app.domain.Aggregates;
using k.backend.app.domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using k.backend.app.domain.Enum;

namespace k.backend.app.data.EntityFramework.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.UserName).IsUnique(true);
            builder.Property(x => x.Password).IsRequired(true);

            builder.HasData(new User("test", "test") { Id = 1 });
        }
    }
}