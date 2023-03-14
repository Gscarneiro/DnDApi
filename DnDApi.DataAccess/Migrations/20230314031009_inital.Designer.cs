﻿// <auto-generated />
using System;
using DnDApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnDApi.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230314031009_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DnDApi.Shared.DTOs.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArmorProficiency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitDice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SavingThrows")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToolsProficiency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponProficiency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubRaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.HasIndex("SubClassId");

                    b.HasIndex("SubRaceId");

                    b.ToTable("Feature", (string)null);
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.Race", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlySpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SwimSpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Race", (string)null);
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("SubClass", (string)null);
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubRace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("SubRace", (string)null);
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.Feature", b =>
                {
                    b.HasOne("DnDApi.Shared.DTOs.Class", null)
                        .WithMany("Features")
                        .HasForeignKey("ClassId");

                    b.HasOne("DnDApi.Shared.DTOs.Race", null)
                        .WithMany("Features")
                        .HasForeignKey("RaceId");

                    b.HasOne("DnDApi.Shared.DTOs.SubClass", null)
                        .WithMany("Features")
                        .HasForeignKey("SubClassId");

                    b.HasOne("DnDApi.Shared.DTOs.SubRace", null)
                        .WithMany("Features")
                        .HasForeignKey("SubRaceId");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubClass", b =>
                {
                    b.HasOne("DnDApi.Shared.DTOs.Class", null)
                        .WithMany("SubClasses")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubRace", b =>
                {
                    b.HasOne("DnDApi.Shared.DTOs.Race", null)
                        .WithMany("SubRaces")
                        .HasForeignKey("RaceId");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.Class", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("SubClasses");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.Race", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("SubRaces");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubClass", b =>
                {
                    b.Navigation("Features");
                });

            modelBuilder.Entity("DnDApi.Shared.DTOs.SubRace", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}