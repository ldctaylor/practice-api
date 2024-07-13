using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_StockId_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Stock_StockID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Stock",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StockID",
                table: "Comments",
                newName: "StockId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_StockID",
                table: "Comments",
                newName: "IX_Comments_StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Stock_StockId",
                table: "Comments",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Stock_StockId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stock",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Comments",
                newName: "StockID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_StockId",
                table: "Comments",
                newName: "IX_Comments_StockID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Stock_StockID",
                table: "Comments",
                column: "StockID",
                principalTable: "Stock",
                principalColumn: "ID");
        }
    }
}
