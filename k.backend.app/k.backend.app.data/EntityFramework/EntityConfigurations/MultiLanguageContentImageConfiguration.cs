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
    public class MultiLanguageContentImageConfiguration : IEntityTypeConfiguration<MultiLanguageContentImage>
    {
        public void Configure(EntityTypeBuilder<MultiLanguageContentImage> builder)
        {
            //diğer propertyler otomatik generate edileceğinden şimdilik müdahale edilmedi.
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.MultiLanguageContent).WithMany(x => x.MultiLanguageContentImages).HasForeignKey(x => x.MultiLanguageContentId);
        }
    }
}