using Microsoft.EntityFrameworkCore;
using Enterprise_Server.Models;

namespace Enterprise_Server;

public class EnterpriseDbContext : DbContext
{
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<EnterpriseEntity> Enterprises { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<CompaundEntity> Compaunds { get; set; }
    public DbSet<MaterialEntity> Materials { get; set; }
    public DbSet<PurcasedMaterialEntity> PurcasedMaterials { get; set; }
    public DbSet<ProviderEntity> Providers { get; set; }



}

