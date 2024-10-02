using System;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
namespace SistemaGestionData.Context;

public class SistemaGestionContext : DbContext  
{
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<ProductoVendido> ProductoVendido { get; set; }
    public DbSet<Venta> Venta { get; set; }
    public SistemaGestionContext()
        : base() {}

    public SistemaGestionContext(DbContextOptions<SistemaGestionContext> options)
        : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(

            "Data Source=NTBCristian;Initial Catalog=SistemaGestion;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

        );
    }
}
