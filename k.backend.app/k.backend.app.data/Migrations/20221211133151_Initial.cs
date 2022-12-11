using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace k.backend.app.data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampaignCodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeASCIIs",
                columns: table => new
                {
                    ASCII = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Character = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeASCIIs", x => x.ASCII);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CodeASCIIs",
                columns: new[] { "ASCII", "Character" },
                values: new object[,]
                {
                    { 50L, "2" },
                    { 51L, "3" },
                    { 52L, "4" },
                    { 53L, "5" },
                    { 55L, "7" },
                    { 57L, "9" },
                    { 65L, "A" },
                    { 67L, "C" },
                    { 68L, "D" },
                    { 69L, "E" },
                    { 70L, "F" },
                    { 71L, "G" },
                    { 72L, "H" },
                    { 75L, "K" },
                    { 76L, "L" },
                    { 77L, "M" },
                    { 78L, "N" },
                    { 80L, "P" },
                    { 82L, "R" },
                    { 84L, "T" },
                    { 88L, "X" },
                    { 89L, "Y" },
                    { 90L, "Z" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "test", "test" });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCodes_Code",
                table: "CampaignCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CodeASCIIs_Character",
                table: "CodeASCIIs",
                column: "Character",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignCodes");

            migrationBuilder.DropTable(
                name: "CodeASCIIs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
