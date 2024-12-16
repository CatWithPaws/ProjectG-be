using Microsoft.EntityFrameworkCore;
using Library;

namespace GameServer.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Players;

        private string _connectionString;

        public GameContext(string connectionString){
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
    }
}