using Microsoft.EntityFrameworkCore.Migrations;

namespace SourceFullStoreDb.Migrations
{
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 1, "Szymon", "Nowutyuicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 2, "Szymoasdas", "Nutyowicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 3, "Szydasdmon", "Noutyuwicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 4, "Szeerewymon", "Notyutwicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 5, "Szymbvcbon", "Nowityutcki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 6, "Szymbvcbon", "Nowutyuicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 7, "Szymhgjghon", "Notyutwicki" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 8, "Szymjghjgon", "Nowiutyucki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
