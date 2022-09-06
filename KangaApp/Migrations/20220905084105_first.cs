using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KangaApp.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ProductNumber = table.Column<int>(name: "Product Number", type: "int", nullable: false),
                    ClientName = table.Column<string>(name: "Client Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ClientAddress = table.Column<string>(name: "Client Address", type: "varchar(max)", unicode: false, nullable: false),
                    ProductName = table.Column<string>(name: "Product Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone Number", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ProductNumber);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductNumber = table.Column<int>(name: "Product Number", type: "int", nullable: false),
                    ProductName = table.Column<string>(name: "Product Name", type: "varchar(max)", unicode: false, nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductNumber);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(name: "Vendor Id", type: "int", nullable: false),
                    VendorName = table.Column<string>(name: "Vendor Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    VendorEmail = table.Column<string>(name: "Vendor Email", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    VendorAddress = table.Column<string>(name: "Vendor Address", type: "varchar(max)", unicode: false, nullable: false),
                    ProductNumber = table.Column<int>(name: "Product Number", type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone Number", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
