using Microsoft.EntityFrameworkCore;

public class OracleDatabase : Database
{
    public OracleDatabase(DbContext options) : base(options) { }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    // }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    // }
}
