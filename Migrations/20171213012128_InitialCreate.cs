using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Poober.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "poopers",
                columns: table => new
                {
                    PooperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 180, nullable: true),
                    City = table.Column<string>(maxLength: 80, nullable: true),
                    DogBreeds = table.Column<string>(maxLength: 280, nullable: true),
                    DogNames = table.Column<string>(maxLength: 280, nullable: true),
                    Dogs = table.Column<int>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Notes = table.Column<string>(maxLength: 1800, nullable: true),
                    Password = table.Column<string>(maxLength: 80, nullable: true),
                    Phone = table.Column<string>(maxLength: 40, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 20, nullable: true),
                    RequireAccess = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(maxLength: 2, nullable: true, defaultValue: "AC"),
                    YardSize = table.Column<decimal>(nullable: false),
                    YardsToService = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_poopers", x => x.PooperID);
                });

            migrationBuilder.CreateTable(
                name: "scoopers",
                columns: table => new
                {
                    ScooperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 180, nullable: true),
                    City = table.Column<string>(maxLength: 80, nullable: true),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Password = table.Column<string>(maxLength: 80, nullable: true),
                    Phone = table.Column<string>(maxLength: 40, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 20, nullable: true),
                    Status = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scoopers", x => x.ScooperID);
                });

            migrationBuilder.CreateTable(
                name: "finishedJobs",
                columns: table => new
                {
                    FinishedJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinishDateTime = table.Column<DateTime>(nullable: false),
                    JobID = table.Column<int>(nullable: false),
                    PooperID = table.Column<int>(nullable: true),
                    ScooperID = table.Column<int>(nullable: true),
                    TotalTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finishedJobs", x => x.FinishedJobID);
                    table.ForeignKey(
                        name: "FK_finishedJobs_poopers_PooperID",
                        column: x => x.PooperID,
                        principalTable: "poopers",
                        principalColumn: "PooperID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_finishedJobs_scoopers_ScooperID",
                        column: x => x.ScooperID,
                        principalTable: "scoopers",
                        principalColumn: "ScooperID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: false),
                    FinishDateTime = table.Column<DateTime>(nullable: false),
                    PooperID = table.Column<int>(nullable: false),
                    PooperNotes = table.Column<string>(maxLength: 600, nullable: true),
                    PooperRating = table.Column<decimal>(nullable: false),
                    ScooperID = table.Column<int>(nullable: false),
                    ScooperNotes = table.Column<string>(maxLength: 600, nullable: true),
                    ScooperRating = table.Column<decimal>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobID);
                    table.ForeignKey(
                        name: "FK_jobs_poopers_PooperID",
                        column: x => x.PooperID,
                        principalTable: "poopers",
                        principalColumn: "PooperID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_jobs_scoopers_ScooperID",
                        column: x => x.ScooperID,
                        principalTable: "scoopers",
                        principalColumn: "ScooperID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_finishedJobs_PooperID",
                table: "finishedJobs",
                column: "PooperID");

            migrationBuilder.CreateIndex(
                name: "IX_finishedJobs_ScooperID",
                table: "finishedJobs",
                column: "ScooperID");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_PooperID",
                table: "jobs",
                column: "PooperID");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_ScooperID",
                table: "jobs",
                column: "ScooperID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "finishedJobs");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "poopers");

            migrationBuilder.DropTable(
                name: "scoopers");
        }
    }
}
