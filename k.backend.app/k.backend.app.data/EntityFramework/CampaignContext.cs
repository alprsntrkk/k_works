using k.backend.app.data.EntityFramework.EntityConfigurations;
using k.backend.app.domain.Aggregates;
using k.backend.app.domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace k.backend.app.data.EntityFramework
{
    public class CampaignContext : DbContext
    {
        public CampaignContext(DbContextOptions<CampaignContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Task 1

            modelBuilder.ApplyConfiguration<CampaignCode>(new CampaignCodeConfiguration());
            modelBuilder.ApplyConfiguration<CodeASCII>(new CodeASCIIConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());

            #endregion Task 1

            #region Task 2

            modelBuilder.ApplyConfiguration<MultiLanguageContent>(new MultiLanguageContentConfiguration());
            modelBuilder.ApplyConfiguration<MultiLanguageContentImage>(new MultiLanguageContentImageConfiguration());

            #endregion Task 2

            base.OnModelCreating(modelBuilder);
        }

        #region Task 1

        public DbSet<CampaignCode> CampaignCodes { get; set; }
        public DbSet<CodeASCII> CodeASCIIs { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion Task 1

        #region Task 2

        /// <summary>
        /// SELECT
        ///     *
        ///     FROM
        ///     MultiLanguageContents
        ///     LEFT JOIN MultiLanguageContentImages
        ///     ON MultiLanguageContents.Id=MultiLanguageContentImages.MultiLanguageContentId
        ///     WHERE LanguageCode ='tr'
        /// </summary>
        public DbSet<MultiLanguageContent> MultiLanguageContents { get; set; }

        public DbSet<MultiLanguageContentImage> MultiLanguageContentImages { get; set; }

        #endregion Task 2
    }
}