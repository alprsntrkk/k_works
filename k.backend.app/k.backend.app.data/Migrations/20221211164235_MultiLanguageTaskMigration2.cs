using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace k.backend.app.data.Migrations
{
    /// <inheritdoc />
    public partial class MultiLanguageTaskMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageCode",
                table: "MultiLanguageContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageCode",
                table: "MultiLanguageContents");
        }
    }
}
