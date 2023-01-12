﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimuTrainApp.Data;

#nullable disable

namespace SimuTrainApp.Migrations
{
    [DbContext(typeof(SimuTrainAppContext))]
    [Migration("20230111123329_databs")]
    partial class databs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SimuTrainApp.Models.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArrivalStationId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ArrivalTime")
                        .HasColumnType("time");

                    b.Property<int?>("DepartureStationId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("DepartureTime")
                        .HasColumnType("time");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Horaire")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalStationId");

                    b.HasIndex("DepartureStationId");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("SimuTrainApp.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("NBParcels")
                        .HasColumnType("int");

                    b.Property<int?>("NBPassenger")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainInStationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainInStationId");

                    b.ToTable("Station");
                });

            modelBuilder.Entity("SimuTrainApp.Models.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NBParcels")
                        .HasColumnType("int");

                    b.Property<int>("NBPassenger")
                        .HasColumnType("int");

                    b.Property<int>("RouteOfTrainId")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RouteOfTrainId");

                    b.ToTable("Train");
                });

            modelBuilder.Entity("SimuTrainApp.Models.Route", b =>
                {
                    b.HasOne("SimuTrainApp.Models.Station", "ArrivalStation")
                        .WithMany()
                        .HasForeignKey("ArrivalStationId");

                    b.HasOne("SimuTrainApp.Models.Station", "DepartureStation")
                        .WithMany()
                        .HasForeignKey("DepartureStationId");

                    b.Navigation("ArrivalStation");

                    b.Navigation("DepartureStation");
                });

            modelBuilder.Entity("SimuTrainApp.Models.Station", b =>
                {
                    b.HasOne("SimuTrainApp.Models.Train", "TrainInStation")
                        .WithMany()
                        .HasForeignKey("TrainInStationId");

                    b.Navigation("TrainInStation");
                });

            modelBuilder.Entity("SimuTrainApp.Models.Train", b =>
                {
                    b.HasOne("SimuTrainApp.Models.Route", "RouteOfTrain")
                        .WithMany()
                        .HasForeignKey("RouteOfTrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RouteOfTrain");
                });
#pragma warning restore 612, 618
        }
    }
}
