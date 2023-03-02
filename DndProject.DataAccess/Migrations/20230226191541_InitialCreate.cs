using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDice = table.Column<int>(type: "int", nullable: false),
                    SavingThrows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArmorProficiency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponProficiency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToolsProficiency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlySpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SwimSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubClass_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubRace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubRace_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubRaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feature_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feature_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feature_SubClass_SubClassId",
                        column: x => x.SubClassId,
                        principalTable: "SubClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feature_SubRace_SubRaceId",
                        column: x => x.SubRaceId,
                        principalTable: "SubRace",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feature_ClassId",
                table: "Feature",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_RaceId",
                table: "Feature",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_SubClassId",
                table: "Feature",
                column: "SubClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_SubRaceId",
                table: "Feature",
                column: "SubRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClass_ClassId",
                table: "SubClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubRace_RaceId",
                table: "SubRace",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "SubClass");

            migrationBuilder.DropTable(
                name: "SubRace");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Race");
        }
    }
}
