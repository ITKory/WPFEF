using Microsoft.EntityFrameworkCore;

namespace WPFL.lib
{
    public class DBConnection : DbContext
    {

        public DbSet<Game> TableGames { get; set; }
        public DBConnection()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=game;Uid=root;Pwd=");
        }
    }
}
