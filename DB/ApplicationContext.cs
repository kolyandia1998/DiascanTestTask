using DiascanTestTask.DB.Models;
using Microsoft.EntityFrameworkCore;


namespace DiascanTestTask.DB;

public class ApplicationContext : DbContext
{
    public DbSet<DataModel> DataModels => Set<DataModel>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<DataModel>().HasKey(m => m.FileName);
    }
}