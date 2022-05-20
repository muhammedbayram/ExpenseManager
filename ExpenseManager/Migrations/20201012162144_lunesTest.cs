using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManager.Migrations
{
    public partial class lunesTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseReport",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(nullable: false),
                    Amount = table.Column<string>(type: "decimal(10, 2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseReport", x => x.ItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseReport");
        }
    }
}
