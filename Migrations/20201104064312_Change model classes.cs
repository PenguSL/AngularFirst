using Microsoft.EntityFrameworkCore.Migrations;

namespace SallonAppointment.Migrations
{
    public partial class Changemodelclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppoinmentId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "AppoinmentId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "AppoinmentNo",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppoinmentId",
                table: "Services",
                column: "AppoinmentId",
                principalTable: "Appointments",
                principalColumn: "AppoinmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppoinmentId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "AppoinmentNo",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "AppoinmentId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppoinmentId",
                table: "Services",
                column: "AppoinmentId",
                principalTable: "Appointments",
                principalColumn: "AppoinmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
