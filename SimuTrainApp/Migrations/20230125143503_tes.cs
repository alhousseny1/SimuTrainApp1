using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuTrainApp.Migrations
{
    public partial class tes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_Train_TrainInStationId",
                table: "Station");

            migrationBuilder.DropIndex(
                name: "IX_Station_TrainInStationId",
                table: "Station");

            migrationBuilder.DropColumn(
                name: "Horaire",
                table: "Route");

            migrationBuilder.AddColumn<int>(
                name: "CurrentStationId",
                table: "Train",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Train",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_ArrivalStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_DepartureStationId",
                table: "Route");

            migrationBuilder.DropColumn(
                name: "CurrentStationId",
                table: "Train");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Train");

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

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Horaire",
                table: "Route",
                type: "time",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Station_TrainInStationId",
                table: "Station",
                column: "TrainInStationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Station_Train_TrainInStationId",
                table: "Station",
                column: "TrainInStationId",
                principalTable: "Train",
                principalColumn: "Id");
        }
    }
}
