using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddPrescriptionMedicamentRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_Medicaments_IdMedicament",
                table: "Prescription_Medicament",
                column: "IdMedicament",
                principalTable: "Medicaments",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_Prescriptions_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_Medicaments_IdMedicament",
                table: "Prescription_Medicament");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_Prescriptions_IdPrescription",
                table: "Prescription_Medicament");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament");
        }
    }
}
