using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_employeeitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmployeeItems",
                columns: new[] { "Id", "Name", "Position", "Salary", "Time" },
                values: new object[,]
                {
                    { 1, "Чепурных Софья", "Директор", 300000, 8 },
                    { 2, "Шаукерова Аделия", "Разработчик", 150000, 8 },
                    { 3, "Шананина Валерия", "Менеджер", 80000, 12 },
                    { 4, "Косишнева Анастасия", "Бухгалтер", 80000, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeItems");
        }
    }
}
