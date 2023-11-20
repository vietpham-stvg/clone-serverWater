using Microsoft.EntityFrameworkCore;

namespace clone_serverWater.Models
{
    public class DataContext: DbContext
    {
        public static Random random = new Random();
        public static string configSql ="Host=localhost;port=5434;Database=clone-serverWater;Username=postgres;Password=12345678";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(configSql);
        }
    }
}
