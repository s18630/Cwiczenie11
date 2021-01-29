using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenie11.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "idDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "jnp@wp.pl", "Jan", "Niezbytny" },
                    { 2, "paw@wp.pl", "Paweł", "Borek" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Lek", "Paracetamol", "doraxny" },
                    { 2, "Lek", "Nospa", "doraxny" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "idPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), "Janusz", "Nierobek" },
                    { 2, new DateTime(2009, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), "Michał", "Boreczko" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions_Medicaments",
                columns: new[] { "id", "Details", "Dose", "IdMedicament", "IdPrescription" },
                values: new object[,]
                {
                    { 1, "details1", 1, null, null },
                    { 2, "details2", 2, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "idDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "idDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "idPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "idPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions_Medicaments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions_Medicaments",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
