using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisverisSitesi.Migrations
{
    public partial class first8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunlar_Categories_CategoryId1",
                table: "Urunlar");

            migrationBuilder.DropIndex(
                name: "IX_Urunlar_CategoryId1",
                table: "Urunlar");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Urunlar");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Urunlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Urunlar_CategoryId",
                table: "Urunlar",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunlar_Categories_CategoryId",
                table: "Urunlar",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunlar_Categories_CategoryId",
                table: "Urunlar");

            migrationBuilder.DropIndex(
                name: "IX_Urunlar_CategoryId",
                table: "Urunlar");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Urunlar",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "CategoryId1",
                table: "Urunlar",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Categories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Urunlar_CategoryId1",
                table: "Urunlar",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunlar_Categories_CategoryId1",
                table: "Urunlar",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
