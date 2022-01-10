using DDDExample.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DDDExample.Infrastructure
{
    public interface IDDDExampleDbContext
    {
        DbSet<Role> Roles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        Task<int> SaveChangesAsync();
    }
}