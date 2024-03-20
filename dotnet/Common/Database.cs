using Microsoft.EntityFrameworkCore;

public class Database : DbContext
{
    public Database(DbContext options) : base(options) { }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    // }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    // }
}
