using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tasked.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30) CHARACTER SET utf8mb4", maxLength: 30, nullable: false),
                    Effort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Effort", "Name" },
                values: new object[] { new Guid("d23a1f89-4f41-4870-bb1f-2d72d401e638"), 5, "Tarefa 1" });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Effort", "Name" },
                values: new object[] { new Guid("3e368b56-3942-47b3-a11b-d273ae3d3dd9"), 1, "Tarefa 2" });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Effort", "Name" },
                values: new object[] { new Guid("50bbbbc8-3e75-4260-8a04-fddccbccba5d"), 10, "Tarefa 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
