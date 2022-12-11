using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace k.backend.app.data.Migrations
{
    /// <inheritdoc />
    public partial class OcrResponseBoundingPolyFKCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoundingPolys_OcrResponses_OcrResponseId",
                table: "BoundingPolys");

            migrationBuilder.DropIndex(
                name: "IX_BoundingPolys_OcrResponseId",
                table: "BoundingPolys");

            migrationBuilder.DropColumn(
                name: "OcrResponseId",
                table: "BoundingPolys");

            migrationBuilder.CreateIndex(
                name: "IX_OcrResponses_BoundingPolyId",
                table: "OcrResponses",
                column: "BoundingPolyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OcrResponses_BoundingPolys_BoundingPolyId",
                table: "OcrResponses",
                column: "BoundingPolyId",
                principalTable: "BoundingPolys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OcrResponses_BoundingPolys_BoundingPolyId",
                table: "OcrResponses");

            migrationBuilder.DropIndex(
                name: "IX_OcrResponses_BoundingPolyId",
                table: "OcrResponses");

            migrationBuilder.AddColumn<long>(
                name: "OcrResponseId",
                table: "BoundingPolys",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_BoundingPolys_OcrResponseId",
                table: "BoundingPolys",
                column: "OcrResponseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BoundingPolys_OcrResponses_OcrResponseId",
                table: "BoundingPolys",
                column: "OcrResponseId",
                principalTable: "OcrResponses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
