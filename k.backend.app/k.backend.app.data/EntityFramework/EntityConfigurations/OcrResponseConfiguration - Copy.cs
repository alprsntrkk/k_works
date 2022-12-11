using k.backend.app.domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace k.backend.app.data.EntityFramework.EntityConfigurations
{
    public class VerticeConfiguration : IEntityTypeConfiguration<Vertice>
    {
        public void Configure(EntityTypeBuilder<Vertice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BoundingPoly).WithMany(x => x.Vertices).HasForeignKey(x => x.BoundingPolyId);
        }
    }
}