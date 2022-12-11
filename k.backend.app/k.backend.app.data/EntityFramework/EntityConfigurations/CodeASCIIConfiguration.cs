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
    public class CodeASCIIConfiguration : IEntityTypeConfiguration<CodeASCII>
    {
        public void Configure(EntityTypeBuilder<CodeASCII> builder)
        {
            builder.HasKey(x => x.ASCII);
            builder.HasIndex(x => x.Character).IsUnique(true);

            builder.HasData(CodeASCII.A,
                            CodeASCII.C,
                            CodeASCII.D,
                            CodeASCII.E,
                            CodeASCII.F,
                            CodeASCII.G,
                            CodeASCII.H,
                            CodeASCII.K,
                            CodeASCII.L,
                            CodeASCII.M,
                            CodeASCII.N,
                            CodeASCII.P,
                            CodeASCII.R,
                            CodeASCII.T,
                            CodeASCII.X,
                            CodeASCII.Y,
                            CodeASCII.Z,
                            CodeASCII.Number2,
                            CodeASCII.Number3,
                            CodeASCII.Number4,
                            CodeASCII.Number5,
                            CodeASCII.Number7,
                            CodeASCII.Number9);
        }
    }
}