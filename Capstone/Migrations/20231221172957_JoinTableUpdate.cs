using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capstone.Migrations
{
    public partial class JoinTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceEmployeeId",
                table: "ServiceEmployeeEntities",
                newName: "ServiceEmployeeEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceEmployeeEntityId",
                table: "ServiceEmployeeEntities",
                newName: "ServiceEmployeeId");
        }
    }
}
