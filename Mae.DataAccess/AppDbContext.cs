using Microsoft.EntityFrameworkCore;

namespace Mae.DataAccess;

public class AppDbContext : DbContext
{
    public const string ConnectionStringName = "AppDbContext";
    
    public DbSet<DayValue> DayValues { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}