using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    commentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentState = table.Column<bool>(type: "bit", nullable: false),
                    destinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_Comments_Destinations_destinationId",
                        column: x => x.destinationId,
                        principalTable: "Destinations",
                        principalColumn: "destinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_destinationId",
                table: "Comments",
                column: "destinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
