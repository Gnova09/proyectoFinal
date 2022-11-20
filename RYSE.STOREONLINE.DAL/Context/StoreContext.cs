using Microsoft.EntityFrameworkCore;
using RYSE.STOREONLINE.DAL.Entities;
using Item = RYSE.STOREONLINE.DAL.Entities.Item;

namespace RYSE.STOREONLINE.DAL.Context
{
    public class StoreContext :DbContext
    {
        
        public StoreContext(DbContextOptions<StoreContext> options)
            :base(options){ 
  
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
      
    }
}
