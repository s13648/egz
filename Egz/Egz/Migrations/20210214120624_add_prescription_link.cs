using Microsoft.EntityFrameworkCore.Migrations;

namespace Egz.Migrations
{
    public partial class add_prescription_link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 1, 2, "Details", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 2 });
        }
    }
}
