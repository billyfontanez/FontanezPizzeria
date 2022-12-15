using FontanezPizzeria.Models;
using Microsoft.EntityFrameworkCore;
namespace FontanezPizzeria.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrderModel> PizzaOrders { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
}