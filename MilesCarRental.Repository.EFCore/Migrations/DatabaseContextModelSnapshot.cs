﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesCarRental.Repository.EFCore;

#nullable disable

namespace MilesCarRental.Repository.EFCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MilesCarRental.Entities.Bookings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DiferentLocation")
                        .HasColumnType("bit");

                    b.Property<Guid>("RentLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RentTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ReturnLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReturnTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("RentLocationId");

                    b.HasIndex("ReturnLocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Cars", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CarLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarLocationId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Locations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserLocationsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserLocationsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Bookings", b =>
                {
                    b.HasOne("MilesCarRental.Entities.Cars", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MilesCarRental.Entities.Locations", "RentLocation")
                        .WithMany()
                        .HasForeignKey("RentLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MilesCarRental.Entities.Locations", "ReturnLocation")
                        .WithMany()
                        .HasForeignKey("ReturnLocationId");

                    b.HasOne("MilesCarRental.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("RentLocation");

                    b.Navigation("ReturnLocation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Cars", b =>
                {
                    b.HasOne("MilesCarRental.Entities.Locations", "CarLocation")
                        .WithMany()
                        .HasForeignKey("CarLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarLocation");
                });

            modelBuilder.Entity("MilesCarRental.Entities.Users", b =>
                {
                    b.HasOne("MilesCarRental.Entities.Locations", "UserLocations")
                        .WithMany()
                        .HasForeignKey("UserLocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
