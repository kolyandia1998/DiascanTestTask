using DiascanTestTask.DB.Models;
using Microsoft.EntityFrameworkCore;


namespace DiascanTestTask.DB;

public class ApplicationContext : DbContext
{
    public DbSet<DataModel> dataModels => Set<DataModel>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DB;Username=postgres;Password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<DataModel>().HasKey(m => m.FileName);
    }
}