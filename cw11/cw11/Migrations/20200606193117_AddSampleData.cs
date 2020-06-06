using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "jankowalski@gmail.com", "Jan", "Kowalski" },
                    { 2, "annanowak@gmail.com", "Anna", "Nowak" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Lek na nadciśnienie", "Noliprel", "Na receptę" },
                    { 2, "Lek na alergię", "Clatra", "Na receptę" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1965, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michał", "Wiśniewski" },
                    { 2, new DateTime(1991, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz", "Wójcik" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 6, 21, 31, 17, 100, DateTimeKind.Local).AddTicks(8729), new DateTime(2020, 7, 6, 21, 31, 17, 105, DateTimeKind.Local).AddTicks(8539), 1, 1 },
                    { 2, new DateTime(2020, 6, 6, 21, 31, 17, 105, DateTimeKind.Local).AddTicks(9939), new DateTime(2020, 7, 6, 21, 31, 17, 105, DateTimeKind.Local).AddTicks(9980), 2, 1 },
                    { 3, new DateTime(2020, 6, 6, 21, 31, 17, 106, DateTimeKind.Local).AddTicks(14), new DateTime(2020, 7, 6, 21, 31, 17, 106, DateTimeKind.Local).AddTicks(19), 2, 2 },
                    { 4, new DateTime(2020, 6, 6, 21, 31, 17, 106, DateTimeKind.Local).AddTicks(25), new DateTime(2020, 7, 6, 21, 31, 17, 106, DateTimeKind.Local).AddTicks(29), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Rano", 1 },
                    { 2, 1, "Rano i wieczorem", 2 },
                    { 1, 2, "Wieczorem", 1 },
                    { 2, 3, "Co 4 h", 3 },
                    { 2, 4, "Po każdym posiłku", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
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
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);
        }
    }
}
