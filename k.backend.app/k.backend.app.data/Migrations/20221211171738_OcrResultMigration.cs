using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace k.backend.app.data.Migrations
{
    /// <inheritdoc />
    public partial class OcrResultMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OcrResponses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoundingPolyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcrResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoundingPolys",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcrResponseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoundingPolys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoundingPolys_OcrResponses_OcrResponseId",
                        column: x => x.OcrResponseId,
                        principalTable: "OcrResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vertices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoundingPolyId = table.Column<long>(type: "bigint", nullable: false),
                    X = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Y = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vertices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vertices_BoundingPolys_BoundingPolyId",
                        column: x => x.BoundingPolyId,
                        principalTable: "BoundingPolys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoundingPolys_OcrResponseId",
                table: "BoundingPolys",
                column: "OcrResponseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vertices_BoundingPolyId",
                table: "Vertices",
                column: "BoundingPolyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vertices");

            migrationBuilder.DropTable(
                name: "BoundingPolys");

            migrationBuilder.DropTable(
                name: "OcrResponses");
        }
    }
}
