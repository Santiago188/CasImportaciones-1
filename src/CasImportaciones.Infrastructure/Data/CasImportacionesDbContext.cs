using Microsoft.EntityFrameworkCore;
using CasImportaciones.Core.Domain;

namespace CasImportaciones.Infrastructure.Data
{
    public class CasImportacionesDbContext : DbContext
    {
        public CasImportacionesDbContext(DbContextOptions<CasImportacionesDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<OrdenCompra> OrdenCompras { get; set; }
        public DbSet<OrdenVenta> OrdenVentas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }
    }
}
