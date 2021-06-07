using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFriends.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1, 34, "John Doe" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 2, 34, "Emily Darris" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 3, 34, "Daniel Smith" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 4, 30, "Anne Laure" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 5, 45, "Jhonny Dyl" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 6, 38, "Jessica Lanny" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");
        }
    }
}
