﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using k.backend.app.data.EntityFramework;

#nullable disable

namespace k.backend.app.data.Migrations
{
    [DbContext(typeof(CampaignContext))]
    [Migration("20221211205937_OcrResponseBoundingPolyFKCorrection")]
    partial class OcrResponseBoundingPolyFKCorrection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("k.backend.app.domain.Aggregates.BoundingPoly", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.HasKey("Id");

                    b.ToTable("BoundingPolys");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.CampaignCode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("CampaignCodes");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.MultiLanguageContent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MultiLanguageContents");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.MultiLanguageContentImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("MultiLanguageContentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MultiLanguageContentId");

                    b.ToTable("MultiLanguageContentImages");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.OcrResponse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BoundingPolyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locale")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoundingPolyId")
                        .IsUnique();

                    b.ToTable("OcrResponses");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "test",
                            UserName = "test"
                        });
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.Vertice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BoundingPolyId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("X")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Y")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BoundingPolyId");

                    b.ToTable("Vertices");
                });

            modelBuilder.Entity("k.backend.app.domain.Enum.CodeASCII", b =>
                {
                    b.Property<long>("ASCII")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ASCII"));

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ASCII");

                    b.HasIndex("Character")
                        .IsUnique();

                    b.ToTable("CodeASCIIs");

                    b.HasData(
                        new
                        {
                            ASCII = 65L,
                            Character = "A"
                        },
                        new
                        {
                            ASCII = 67L,
                            Character = "C"
                        },
                        new
                        {
                            ASCII = 68L,
                            Character = "D"
                        },
                        new
                        {
                            ASCII = 69L,
                            Character = "E"
                        },
                        new
                        {
                            ASCII = 70L,
                            Character = "F"
                        },
                        new
                        {
                            ASCII = 71L,
                            Character = "G"
                        },
                        new
                        {
                            ASCII = 72L,
                            Character = "H"
                        },
                        new
                        {
                            ASCII = 75L,
                            Character = "K"
                        },
                        new
                        {
                            ASCII = 76L,
                            Character = "L"
                        },
                        new
                        {
                            ASCII = 77L,
                            Character = "M"
                        },
                        new
                        {
                            ASCII = 78L,
                            Character = "N"
                        },
                        new
                        {
                            ASCII = 80L,
                            Character = "P"
                        },
                        new
                        {
                            ASCII = 82L,
                            Character = "R"
                        },
                        new
                        {
                            ASCII = 84L,
                            Character = "T"
                        },
                        new
                        {
                            ASCII = 88L,
                            Character = "X"
                        },
                        new
                        {
                            ASCII = 89L,
                            Character = "Y"
                        },
                        new
                        {
                            ASCII = 90L,
                            Character = "Z"
                        },
                        new
                        {
                            ASCII = 50L,
                            Character = "2"
                        },
                        new
                        {
                            ASCII = 51L,
                            Character = "3"
                        },
                        new
                        {
                            ASCII = 52L,
                            Character = "4"
                        },
                        new
                        {
                            ASCII = 53L,
                            Character = "5"
                        },
                        new
                        {
                            ASCII = 55L,
                            Character = "7"
                        },
                        new
                        {
                            ASCII = 57L,
                            Character = "9"
                        });
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.MultiLanguageContentImage", b =>
                {
                    b.HasOne("k.backend.app.domain.Aggregates.MultiLanguageContent", "MultiLanguageContent")
                        .WithMany("MultiLanguageContentImages")
                        .HasForeignKey("MultiLanguageContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MultiLanguageContent");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.OcrResponse", b =>
                {
                    b.HasOne("k.backend.app.domain.Aggregates.BoundingPoly", "BoundingPoly")
                        .WithOne("OcrResponse")
                        .HasForeignKey("k.backend.app.domain.Aggregates.OcrResponse", "BoundingPolyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoundingPoly");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.Vertice", b =>
                {
                    b.HasOne("k.backend.app.domain.Aggregates.BoundingPoly", "BoundingPoly")
                        .WithMany("Vertices")
                        .HasForeignKey("BoundingPolyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoundingPoly");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.BoundingPoly", b =>
                {
                    b.Navigation("OcrResponse")
                        .IsRequired();

                    b.Navigation("Vertices");
                });

            modelBuilder.Entity("k.backend.app.domain.Aggregates.MultiLanguageContent", b =>
                {
                    b.Navigation("MultiLanguageContentImages");
                });
#pragma warning restore 612, 618
        }
    }
}
