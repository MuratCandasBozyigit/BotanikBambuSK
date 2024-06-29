using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace BotanikBambu.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customerİnfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    TelNo = table.Column<string>(type: "longtext", nullable: false),
                    Adress = table.Column<string>(type: "longtext", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customerİnfos", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orderİnfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<string>(type: "longtext", nullable: false),
                    orderName = table.Column<string>(type: "longtext", nullable: false),
                    orderColor = table.Column<string>(type: "longtext", nullable: false),
                    chairNumber = table.Column<int>(type: "int", nullable: false),
                    chairType = table.Column<string>(type: "longtext", nullable: false),
                    isChairAjurlu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tableSizes = table.Column<string>(type: "longtext", nullable: false),
                    tableType = table.Column<string>(type: "longtext", nullable: false),
                    isTableAjurlu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sargıType = table.Column<string>(type: "longtext", nullable: false),
                    sargıColor = table.Column<string>(type: "longtext", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    cushionColor = table.Column<string>(type: "longtext", nullable: true),
                    cushionButtonNumber = table.Column<string>(type: "longtext", nullable: true),
                    OrderİnfoId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderİnfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orderİnfos_Orderİnfos_OrderİnfoId",
                        column: x => x.OrderİnfoId,
                        principalTable: "Orderİnfos",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Truckerİnfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    truckerName = table.Column<int>(type: "int", nullable: false),
                    truckerTelNo = table.Column<string>(type: "longtext", nullable: false),
                    truckPlateNo = table.Column<string>(type: "longtext", nullable: false),
                    truckColor = table.Column<string>(type: "longtext", nullable: false),
                    truckType = table.Column<string>(type: "longtext", nullable: false),
                    receivedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deliveryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OrderİnfoId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truckerİnfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Truckerİnfos_Orderİnfos_OrderİnfoId",
                        column: x => x.OrderİnfoId,
                        principalTable: "Orderİnfos",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Orderİnfos_OrderİnfoId",
                table: "Orderİnfos",
                column: "OrderİnfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Truckerİnfos_OrderİnfoId",
                table: "Truckerİnfos",
                column: "OrderİnfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customerİnfos");

            migrationBuilder.DropTable(
                name: "Truckerİnfos");

            migrationBuilder.DropTable(
                name: "Orderİnfos");
        }
    }
}
