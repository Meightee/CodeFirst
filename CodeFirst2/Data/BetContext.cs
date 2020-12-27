using Microsoft.EntityFrameworkCore;
using CodeFirst2.Data.Models;

namespace CodeFirst2.Data
{
    public class BetContext : DbContext
    {
        public BetContext()
        {
        }

        public BetContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=Bets;Integrated Security = true;Trusted_Connection=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>(e =>
                e.HasKey(ps => new {ps.PlayerId, ps.GameId}));
            
            modelBuilder.Entity<Color>(e =>
                e.HasMany<Team>(color => color.PrimaryKitTeams).WithOne(team => team.PrimaryKitColor).OnDelete(DeleteBehavior.NoAction));
            
            modelBuilder.Entity<Color>(e =>
                e.HasMany<Team>(color => color.SecondaryKitTeams).WithOne(team => team.SecondaryKitColor).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.HomeGames).WithOne(g => g.HomeTeam).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.AwayGames).WithOne(g => g.AwayTeam).OnDelete(DeleteBehavior.NoAction));
        }
    }
}