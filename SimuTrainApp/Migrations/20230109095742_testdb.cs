using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuTrainApp.Migrations
{
    public partial class testdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureStationId = table.Column<int>(type: "int", nullable: true),
                    DepartureTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ArrivalTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    ArrivalStationId = table.Column<int>(type: "int", nullable: true),
                    Horaire = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    NBPassenger = table.Column<int>(type: "int", nullable: false),
                    NBParcels = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    RouteOfTrainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Train_Route_RouteOfTrainId",
                        column: x => x.RouteOfTrainId,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NBParcels = table.Column<int>(type: "int", nullable: false),
                    NBPassenger = table.Column<int>(type: "int", nullable: false),
                    TrainInStationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Station_Train_TrainInStationId",
                        column: x => x.TrainInStationId,
                        principalTable: "Train",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Route_ArrivalStationId",
                table: "Route",
                column: "ArrivalStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_DepartureStationId",
                table: "Route",
                column: "DepartureStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Station_TrainInStationId",
                table: "Station",
                column: "TrainInStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Train_RouteOfTrainId",
                table: "Train",
                column: "RouteOfTrainId");

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

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.DropTable(
                name: "Route");
        }
    }
}
