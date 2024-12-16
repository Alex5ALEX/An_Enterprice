using Enterprise_Server.Configarations;
using Enterprise_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Server.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<OrderCompaund> OrderCompaunds { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<SupplyCompaund> SupplyCompaunds { get; set; }

    public DbSet<Supply> Supplies { get; set; }

    public DbSet<Provider> Providers { get; set; }

    public DbSet<Enterprise> Enterprises { get; set; }

    public DbSet<MaterialCompaund> MaterialCompaunds { get; set; }

    public DbSet<Material> Materials { get; set; }




    //настройка строки подключения
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
        var connectionString = "server=localhost;port=3306;database=Enterprise;user id=root;password=BuildSQLData;";

        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MaterialComapundConfiguration());
        modelBuilder.ApplyConfiguration(new OrderComapundConfiguration());
        modelBuilder.ApplyConfiguration(new SupplyComapundConfiguration());

        base.OnModelCreating(modelBuilder);
    }

}
