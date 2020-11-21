﻿// <auto-generated />
using System;
using CINEMA_DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CINEMA_DB.Migrations
{
    [DbContext(typeof(CINEMA_DBContext))]
    partial class CINEMA_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CINEMA_DB.Models.Film", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgeRestrictions")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("GenreID")
                        .HasColumnType("bigint");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Genre", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("FilmID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FilmID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Demands")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Repertoire", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Repertoire");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Seat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Occupancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<long?>("SeatID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("SeatID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Genre", b =>
                {
                    b.HasOne("CINEMA_DB.Models.Film", null)
                        .WithMany("Genre")
                        .HasForeignKey("FilmID");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Position", b =>
                {
                    b.HasOne("CINEMA_DB.Models.Staff", null)
                        .WithMany("Position")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Staff", b =>
                {
                    b.HasOne("CINEMA_DB.Models.Seat", null)
                        .WithMany("Staff")
                        .HasForeignKey("SeatID");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Film", b =>
                {
                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Seat", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("CINEMA_DB.Models.Staff", b =>
                {
                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
