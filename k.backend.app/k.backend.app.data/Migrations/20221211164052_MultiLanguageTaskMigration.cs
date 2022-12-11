using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace k.backend.app.data.Migrations
{
    /// <inheritdoc />
    public partial class MultiLanguageTaskMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MultiLanguageContents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiLanguageContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultiLanguageContentImages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MultiLanguageContentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiLanguageContentImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiLanguageContentImages_MultiLanguageContents_MultiLanguageContentId",
                        column: x => x.MultiLanguageContentId,
                        principalTable: "MultiLanguageContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageContentImages_MultiLanguageContentId",
                table: "MultiLanguageContentImages",
                column: "MultiLanguageContentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MultiLanguageContentImages");

            migrationBuilder.DropTable(
                name: "MultiLanguageContents");
        }
    }
}
