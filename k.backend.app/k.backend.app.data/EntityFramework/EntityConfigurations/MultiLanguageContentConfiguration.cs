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
    public class MultiLanguageContentConfiguration : IEntityTypeConfiguration<MultiLanguageContent>
    {
        public void Configure(EntityTypeBuilder<MultiLanguageContent> builder)
        {
            //diğer propertyler otomatik generate edileceğinden şimdilik müdahale edilmedi.
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.MultiLanguageContentImages).WithOne(x => x.MultiLanguageContent).HasForeignKey(x => x.MultiLanguageContentId);
        }
    }
}