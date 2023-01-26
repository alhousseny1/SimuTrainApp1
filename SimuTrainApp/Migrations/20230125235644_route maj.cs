using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuTrainApp.Migrations
{
    public partial class routemaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route");

            migrationBuilder.AlterColumn<int>(
                name: "DepartureStationId",
                table: "Route",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalStationId",
                table: "Route",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route",
                column: "ArrivalStationId",
                principalTable: "Station",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route",
                column: "DepartureStationId",
                principalTable: "Station",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route");

            migrationBuilder.AlterColumn<int>(
                name: "DepartureStationId",
                table: "Route",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalStationId",
                table: "Route",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route",
                column: "ArrivalStationId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route",
                column: "DepartureStationId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
