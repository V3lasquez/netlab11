
using Microsoft.EntityFrameworkCore;

namespace netlab11.Models
{
    public class DemoContext : DbContext
    {
        //mapear todas las tablas y la cadena de conexion
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-17\\SQLEXPRESS; Initial Catalog=DB11; Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
