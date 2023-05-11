using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coronas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaccinationDate1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vaccinationDate2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vaccinationDate3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vaccinationDate4 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vaccineManufacturer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vaccineManufacturer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vaccineManufacturer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vaccineManufacturer4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateRecovery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datePositiveResult = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coronas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numStreet = table.Column<int>(type: "int", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    coronaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patients_Coronas_coronaid",
                        column: x => x.coronaid,
                        principalTable: "Coronas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_coronaid",
                table: "Patients",
                column: "coronaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Coronas");
        }
    }
}
