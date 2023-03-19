using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class AddIsActivetoLeaveType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeLeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeLeaveTypes");
        }
    }
}
