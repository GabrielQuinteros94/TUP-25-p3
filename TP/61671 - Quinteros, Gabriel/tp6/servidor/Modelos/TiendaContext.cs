using Microsoft.EntityFrameworkCore;
using servidor.Modelos;

namespace servidor.Modelos
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ItemCompra> ItemsCompra { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<ItemCarrito> ItemsCarrito { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrito>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Carrito)
                .HasForeignKey(i => i.CarritoId);

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Toyota Corolla", Descripcion = "Sedán compacto, motor 1.8L", Precio = 12000000, Stock = 5, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_9b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 2, Nombre = "Ford Fiesta", Descripcion = "Hatchback, motor 1.6L", Precio = 9500000, Stock = 7, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_8b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 3, Nombre = "Volkswagen Golf", Descripcion = "Hatchback, motor 1.4L", Precio = 11000000, Stock = 4, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_7b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 4, Nombre = "Renault Sandero", Descripcion = "Hatchback, motor 1.6L", Precio = 8000000, Stock = 6, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_6b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 5, Nombre = "Chevrolet Onix", Descripcion = "Hatchback, motor 1.0L", Precio = 8500000, Stock = 8, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_5b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 6, Nombre = "Peugeot 208", Descripcion = "Hatchback, motor 1.2L", Precio = 9000000, Stock = 5, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_4b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 7, Nombre = "Fiat Cronos", Descripcion = "Sedán, motor 1.3L", Precio = 9500000, Stock = 7, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_3b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 8, Nombre = "Honda Fit", Descripcion = "Hatchback, motor 1.5L", Precio = 10500000, Stock = 3, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_2b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 9, Nombre = "Nissan Versa", Descripcion = "Sedán, motor 1.6L", Precio = 11500000, Stock = 4, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_1b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" },
                new Producto { Id = 10, Nombre = "Kia Rio", Descripcion = "Hatchback, motor 1.4L", Precio = 9800000, Stock = 6, ImagUrl = "https://acroadtrip.blob.core.windows.net/catalogo-imagenes/xl/RT_V_0b7e7e2b5e7e4f8c8b7e7e2b5e7e4f8c.jpg" }
            );
        }

        public async Task<int> GuardarCambiosAsync()
        {
            await SaveChangesAsync();
            return 0;
        }
    }
}