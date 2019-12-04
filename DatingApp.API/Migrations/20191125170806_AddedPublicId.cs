using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class AddedPublicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterColumn<string>(
            //     name: "Interests",
            //     table: "Users",
            //     nullable: true,
            //     oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PublicID",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicID",
                table: "Photos");

            // migrationBuilder.AlterColumn<int>(
            //     name: "Interests",
            //     table: "Users",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldNullable: true);
        }
    }
}
