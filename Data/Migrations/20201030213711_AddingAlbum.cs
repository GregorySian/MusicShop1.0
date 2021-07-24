using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicHub.Data.Migrations
{
    public partial class AddingAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Albums",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Title = table.Column<string>(nullable: true),
                   Artist = table.Column<string>(nullable: true),
                   Genre = table.Column<string>(nullable: true),
                   ImageUrl = table.Column<string>(nullable: true),
                   Year = table.Column<int>(nullable: false),
                   Price = table.Column<decimal>(nullable: false),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Albums", x => x.Id);

               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
             name: "Albums");
        }
    }
}
