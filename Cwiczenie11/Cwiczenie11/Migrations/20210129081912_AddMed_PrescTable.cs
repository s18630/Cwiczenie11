using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenie11.Migrations
{
    public partial class AddMed_PrescTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescriptions_Medicaments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrescription = table.Column<int>(nullable: true),
                    IdMedicament = table.Column<int>(nullable: true),
                    Dose = table.Column<int>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions_Medicaments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicaments_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicaments_Prescriptions_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescriptions",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_Medicaments_IdMedicament",
                table: "Prescriptions_Medicaments",
                column: "IdMedicament");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_Medicaments_IdPrescription",
                table: "Prescriptions_Medicaments",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescriptions_Medicaments");
        }
    }
}
