using Common.Models;
using Connection.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Connection
{
    public class ConnectionContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Moto> Moto { get; set; }
        public DbSet<Mantenimiento> Mantenimiento { get; set; }
        public DbSet<Producto> Producto { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=desktop-4114k5a; database = FranMotors; integrated security = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new MotoMap());
            modelBuilder.ApplyConfiguration(new MantenimientoMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
        }
    }
}
