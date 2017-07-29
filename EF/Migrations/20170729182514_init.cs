using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HqyBiggestLoserApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamPoints",
                columns: table => new
                {
                    TeamPointsId = table.Column<int>(nullable: false),
                    Points = table.Column<decimal>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPoints", x => x.TeamPointsId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPoints",
                columns: table => new
                {
                    UserPointsId = table.Column<int>(nullable: false),
                    Points = table.Column<decimal>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPoints", x => x.UserPointsId);
                });

            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    WeekNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyChallenges",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    ChallengeName = table.Column<string>(nullable: true),
                    WeekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyChallenges", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyIndividualPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TeamPoints = table.Column<decimal>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    WeekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyIndividualPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyTeamPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    TeamPoints = table.Column<decimal>(nullable: false),
                    WeekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyTeamPoints", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "TeamPoints");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserPoints");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropTable(
                name: "WeeklyChallenges");

            migrationBuilder.DropTable(
                name: "WeeklyIndividualPoints");

            migrationBuilder.DropTable(
                name: "WeeklyTeamPoints");
        }
    }
}
