using Microsoft.EntityFrameworkCore.Migrations;

namespace SourceFullStoreDb.Migrations
{
    public partial class Cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { 1, "Kielce", 250000 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { 2, "Łódź", 550000 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { 3, "Lublin", 450000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
