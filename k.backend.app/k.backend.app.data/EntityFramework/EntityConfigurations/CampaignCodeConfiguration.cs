using k.backend.app.domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.data.EntityFramework.EntityConfigurations
{
    public class CampaignCodeConfiguration : IEntityTypeConfiguration<CampaignCode>
    {
        public void Configure(EntityTypeBuilder<CampaignCode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Code).IsUnique(true);
        }
    }
}