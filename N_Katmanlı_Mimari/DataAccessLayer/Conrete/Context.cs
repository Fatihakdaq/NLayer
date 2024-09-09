using EntityLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DLE71NS\\SQLEXPRESS;Database=ProductDb;User Id=car;Password=123456;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<ReservationUser> ReservationUsers { get; set; } 
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Room> Room { get; set; }

    }
}
