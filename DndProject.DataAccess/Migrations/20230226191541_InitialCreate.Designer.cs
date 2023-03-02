﻿// <auto-generated />
using System;
using DnDProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnDProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230226191541_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DnDProject.Models.Class", b =>
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

            modelBuilder.Entity("DnDProject.Models.Feature", b =>
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

            modelBuilder.Entity("DnDProject.Models.Race", b =>
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

            modelBuilder.Entity("DnDProject.Models.SubClass", b =>
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

            modelBuilder.Entity("DnDProject.Models.SubRace", b =>
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

            modelBuilder.Entity("DnDProject.Models.Feature", b =>
                {
                    b.HasOne("DnDProject.Models.Class", null)
                        .WithMany("Features")
                        .HasForeignKey("ClassId");

                    b.HasOne("DnDProject.Models.Race", null)
                        .WithMany("Features")
                        .HasForeignKey("RaceId");

                    b.HasOne("DnDProject.Models.SubClass", null)
                        .WithMany("Features")
                        .HasForeignKey("SubClassId");

                    b.HasOne("DnDProject.Models.SubRace", null)
                        .WithMany("Features")
                        .HasForeignKey("SubRaceId");
                });

            modelBuilder.Entity("DnDProject.Models.SubClass", b =>
                {
                    b.HasOne("DnDProject.Models.Class", null)
                        .WithMany("SubClasses")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("DnDProject.Models.SubRace", b =>
                {
                    b.HasOne("DnDProject.Models.Race", null)
                        .WithMany("SubRaces")
                        .HasForeignKey("RaceId");
                });

            modelBuilder.Entity("DnDProject.Models.Class", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("SubClasses");
                });

            modelBuilder.Entity("DnDProject.Models.Race", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("SubRaces");
                });

            modelBuilder.Entity("DnDProject.Models.SubClass", b =>
                {
                    b.Navigation("Features");
                });

            modelBuilder.Entity("DnDProject.Models.SubRace", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}