using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BiggestLoserEF;

namespace HqyBiggestLoserApi.Migrations
{
    [DbContext(typeof(BiggestLoserDbContext))]
    [Migration("20170729232941_columnUpdate")]
    partial class columnUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiggestLoserEF.Models.Team", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.TeamPoints", b =>
                {
                    b.Property<int>("TeamPointsId");

                    b.Property<decimal>("Points");

                    b.Property<int>("TeamId");

                    b.HasKey("TeamPointsId");

                    b.ToTable("TeamPoints");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.User", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("InitialWeight");

                    b.Property<string>("LastName");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.UserPoints", b =>
                {
                    b.Property<int>("UserPointsId");

                    b.Property<decimal>("Points");

                    b.Property<int>("UserId");

                    b.HasKey("UserPointsId");

                    b.ToTable("UserPoints");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.Week", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("WeekNumber");

                    b.HasKey("Id");

                    b.ToTable("Week");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.WeeklyChallenges", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("ChallengeName");

                    b.Property<int>("WeekId");

                    b.HasKey("id");

                    b.ToTable("WeeklyChallenges");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.WeeklyIndividualPoints", b =>
                {
                    b.Property<int>("Id");

                    b.Property<decimal>("TeamPoints");

                    b.Property<int>("UserId");

                    b.Property<int>("WeekId");

                    b.HasKey("Id");

                    b.ToTable("WeeklyIndividualPoints");
                });

            modelBuilder.Entity("BiggestLoserEF.Models.WeeklyTeamPoints", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("TeamId");

                    b.Property<decimal>("TeamPoints");

                    b.Property<int>("WeekId");

                    b.HasKey("Id");

                    b.ToTable("WeeklyTeamPoints");
                });
        }
    }
}
