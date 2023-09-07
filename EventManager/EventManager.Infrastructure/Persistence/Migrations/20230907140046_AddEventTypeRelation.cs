using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManager.Infrastructure.Migrations
{
    public partial class AddEventTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventType",
                table: "EventLogs");

            migrationBuilder.AddColumn<int>(
                name: "EventTypeId",
                table: "EventLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventLogs_EventTypeId",
                table: "EventLogs",
                column: "EventTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventLogs_EventType_EventTypeId",
                table: "EventLogs",
                column: "EventTypeId",
                principalTable: "EventType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventLogs_EventType_EventTypeId",
                table: "EventLogs");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropIndex(
                name: "IX_EventLogs_EventTypeId",
                table: "EventLogs");

            migrationBuilder.DropColumn(
                name: "EventTypeId",
                table: "EventLogs");

            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "EventLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
