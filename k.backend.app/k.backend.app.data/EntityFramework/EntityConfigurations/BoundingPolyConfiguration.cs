using k.backend.app.domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace k.backend.app.data.EntityFramework.EntityConfigurations
{
    public class BoundingPolyConfiguration : IEntityTypeConfiguration<BoundingPoly>
    {
        public void Configure(EntityTypeBuilder<BoundingPoly> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.OcrResponse).WithOne(x => x.BoundingPoly).HasForeignKey<OcrResponse>(x => x.BoundingPolyId);
            builder.HasMany(x => x.Vertices).WithOne(x => x.BoundingPoly).HasForeignKey(x => x.BoundingPolyId);
        }
    }
}