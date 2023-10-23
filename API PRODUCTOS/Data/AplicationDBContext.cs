using API_PRODUCTOS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PRODUCTOS.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(
            DbContextOptions<AplicationDBContext> options
            ) : base(options) { }

        public DbSet<Producto> Producto {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
                modelBuilder.Entity<Producto>().HasData(

                    new Producto{
                    IdProducto = 1,
                    Nombre="Producto",
                    Descripcion="xfgx",
                    Cantidad=12
                    },

                    new Producto
                    {
                        IdProducto = 2,
                        Nombre = "Producto",
                        Descripcion = "utyr",
                        Cantidad = 22
                    }

            );
           
        }
        

    }
}
