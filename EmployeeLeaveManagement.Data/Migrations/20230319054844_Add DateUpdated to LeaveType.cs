using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class AddDateUpdatedtoLeaveType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "EmployeeLeaveTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "EmployeeLeaveTypes");
        }
    }
}
