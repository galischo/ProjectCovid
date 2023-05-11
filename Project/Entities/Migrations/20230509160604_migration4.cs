using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Coronas_coronaid",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_coronaid",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "coronaid",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "vaccinationDate1",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "vaccinationDate2",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "vaccinationDate3",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "vaccineManufacturer1",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "vaccineManufacturer2",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "vaccineManufacturer3",
                table: "Coronas");

            migrationBuilder.RenameColumn(
                name: "vaccineManufacturer4",
                table: "Coronas",
                newName: "vaccineManufacturer");

            migrationBuilder.RenameColumn(
                name: "vaccinationDate4",
                table: "Coronas",
                newName: "vaccinationDate");

            migrationBuilder.AddColumn<int>(
                name: "patientId",
                table: "Coronas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coronas_patientId",
                table: "Coronas",
                column: "patientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coronas_Patients_patientId",
                table: "Coronas",
                column: "patientId",
                principalTable: "Patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coronas_Patients_patientId",
                table: "Coronas");

            migrationBuilder.DropIndex(
                name: "IX_Coronas_patientId",
                table: "Coronas");

            migrationBuilder.DropColumn(
                name: "patientId",
                table: "Coronas");

            migrationBuilder.RenameColumn(
                name: "vaccineManufacturer",
                table: "Coronas",
                newName: "vaccineManufacturer4");

            migrationBuilder.RenameColumn(
                name: "vaccinationDate",
                table: "Coronas",
                newName: "vaccinationDate4");

            migrationBuilder.AddColumn<int>(
                name: "coronaid",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "vaccinationDate1",
                table: "Coronas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "vaccinationDate2",
                table: "Coronas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "vaccinationDate3",
                table: "Coronas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "vaccineManufacturer1",
                table: "Coronas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vaccineManufacturer2",
                table: "Coronas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vaccineManufacturer3",
                table: "Coronas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_coronaid",
                table: "Patients",
                column: "coronaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Coronas_coronaid",
                table: "Patients",
                column: "coronaid",
                principalTable: "Coronas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
