using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "Nvarchar(70)", nullable: false),
                    InternationalCode = table.Column<string>(type: "Nvarchar(10)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "Nvarchar(20)", nullable: false),
                    Address = table.Column<string>(type: "Nvarchar(1000)", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
