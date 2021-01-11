using Microsoft.EntityFrameworkCore.Migrations;

namespace WordStack.Api.Migrations
{
    public partial class Addingwordtypeidtowords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WordTypeId",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Words_WordTypeId",
                table: "Words",
                column: "WordTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_WordTypes_WordTypeId",
                table: "Words",
                column: "WordTypeId",
                principalTable: "WordTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_WordTypes_WordTypeId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_WordTypeId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "WordTypeId",
                table: "Words");
        }
    }
}
