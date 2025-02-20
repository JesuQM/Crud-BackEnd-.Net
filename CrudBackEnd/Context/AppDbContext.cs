using CrudBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBackEnd.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
    
    }
}
