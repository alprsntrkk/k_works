using k.backend.app.data.EntityFramework.EntityConfigurations;
using k.backend.app.domain.Aggregates;
using k.backend.app.domain.Enum;
using Microsoft.EntityFrameworkCore;
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
            base.OnModelCreating(modelBuilder);
        }

        #region Task 1
        public DbSet<CampaignCode> CampaignCodes { get; set; }
        public DbSet<CodeASCII> CodeASCIIs { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion
    }
}