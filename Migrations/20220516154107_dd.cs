using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment_Sytem.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_payment_requested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Invoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_For = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_of_payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_Number = table.Column<int>(type: "int", nullable: false),
                    Manager_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager_Signature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
