using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Employees",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Employees",
                newName: "Start_Date");

            migrationBuilder.AddColumn<string>(
                name: "Assigned_To",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "End_Date",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Assigned_To",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "End_Date",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Employees",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Start_Date",
                table: "Employees",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNo",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
