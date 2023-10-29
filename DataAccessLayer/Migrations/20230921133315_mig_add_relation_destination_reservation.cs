using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_relation_destination_reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "destinationId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_destinationId",
                table: "Reservations",
                column: "destinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_destinationId",
                table: "Reservations",
                column: "destinationId",
                principalTable: "Destinations",
                principalColumn: "destinationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_destinationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_destinationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "destinationId",
                table: "Reservations");
        }
    }
}
