using System.Data.Entity;

namespace CallCenter.Models
{
    public class AveriaContext : DbContext
    {
        public AveriaContext() : base("CallCenter")
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Averia> Averias { get; set; }

    public DbSet<CartItem> ShoppingCartItems { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
  }
    
}