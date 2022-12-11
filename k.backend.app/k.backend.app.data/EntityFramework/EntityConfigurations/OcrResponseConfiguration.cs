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
    public class OcrResponseConfiguration : IEntityTypeConfiguration<OcrResponse>
    {
        public void Configure(EntityTypeBuilder<OcrResponse> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BoundingPoly).WithOne(x => x.OcrResponse).HasForeignKey<OcrResponse>(x => x.BoundingPolyId);
            builder.Property(x => x.Locale).IsRequired(false);
        }
    }
}