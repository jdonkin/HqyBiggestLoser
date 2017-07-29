using BiggestLoserEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BiggestLoserEF
{
    public class BiggestLoserDbContext : DbContext
    {
        public BiggestLoserDbContext(DbContextOptions<BiggestLoserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<WeeklyChallenges> Challenges { get; set; }
        public DbSet<WeeklyTeamPoints> WeeklyTeamPoints { get; set; }
        public DbSet<WeeklyIndividualPoints> WeeklyUserPoints { get; set; }
        public DbSet<UserPoints> UserPoints { get; set; }
        public DbSet<TeamPoints> TeamPoints { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("User").HasKey(k=> k.Id);
            builder.Entity<Team>().ToTable("Team").HasKey(k=> k.Id);
            builder.Entity<Week>().ToTable("Week").HasKey(k=>k.Id);
            builder.Entity<WeeklyChallenges>().ToTable("WeeklyChallenges").HasKey(k=>k.id);
            builder.Entity<WeeklyTeamPoints>().ToTable("WeeklyTeamPoints").HasKey(k=>k.Id);
            builder.Entity<WeeklyIndividualPoints>().ToTable("WeeklyIndividualPoints").HasKey(k=>k.Id);
            builder.Entity<UserPoints>().ToTable("UserPoints").HasKey(k=>k.UserPointsId);
            builder.Entity<TeamPoints>().ToTable("TeamPoints").HasKey(k=>k.TeamPointsId);
        }
    }
}
