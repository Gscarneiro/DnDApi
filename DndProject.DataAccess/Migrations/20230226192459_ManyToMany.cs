using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDProject.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Class_ClassId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Race_RaceId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_SubClass_SubClassId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_SubRace_SubRaceId",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_ClassId",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_RaceId",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_SubClassId",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_SubRaceId",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "SubClassId",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "SubRaceId",
                table: "Feature");

            migrationBuilder.CreateTable(
                name: "ClassFeature",
                columns: table => new
                {
                    ClassesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassFeature", x => new { x.ClassesId, x.FeaturesId });
                    table.ForeignKey(
                        name: "FK_ClassFeature_Class_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassFeature_Feature_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureRace",
                columns: table => new
                {
                    FeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RacesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureRace", x => new { x.FeaturesId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_FeatureRace_Feature_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureRace_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureSubClass",
                columns: table => new
                {
                    FeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubClassesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureSubClass", x => new { x.FeaturesId, x.SubClassesId });
                    table.ForeignKey(
                        name: "FK_FeatureSubClass_Feature_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureSubClass_SubClass_SubClassesId",
                        column: x => x.SubClassesId,
                        principalTable: "SubClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureSubRace",
                columns: table => new
                {
                    FeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubRacesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureSubRace", x => new { x.FeaturesId, x.SubRacesId });
                    table.ForeignKey(
                        name: "FK_FeatureSubRace_Feature_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureSubRace_SubRace_SubRacesId",
                        column: x => x.SubRacesId,
                        principalTable: "SubRace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeature_FeaturesId",
                table: "ClassFeature",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureRace_RacesId",
                table: "FeatureRace",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureSubClass_SubClassesId",
                table: "FeatureSubClass",
                column: "SubClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureSubRace_SubRacesId",
                table: "FeatureSubRace",
                column: "SubRacesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassFeature");

            migrationBuilder.DropTable(
                name: "FeatureRace");

            migrationBuilder.DropTable(
                name: "FeatureSubClass");

            migrationBuilder.DropTable(
                name: "FeatureSubRace");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Feature",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RaceId",
                table: "Feature",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubClassId",
                table: "Feature",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubRaceId",
                table: "Feature",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Class_ClassId",
                table: "Feature",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Race_RaceId",
                table: "Feature",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_SubClass_SubClassId",
                table: "Feature",
                column: "SubClassId",
                principalTable: "SubClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_SubRace_SubRaceId",
                table: "Feature",
                column: "SubRaceId",
                principalTable: "SubRace",
                principalColumn: "Id");
        }
    }
}
