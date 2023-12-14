using Microsoft.EntityFrameworkCore;

namespace Mae.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<DayValue> DayValues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("");
    }
}