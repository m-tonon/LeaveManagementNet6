using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class changecontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveTypes",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "LeaveTypes",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveAllocations",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "LeaveAllocations",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "LeaveTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "LeaveTypes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "LeaveAllocations",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "LeaveAllocations",
                newName: "DateCreated");
        }
    }
}
