using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.Models;

namespace PizzaShopAPI.Data
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext(DbContextOptions<PizzaShopContext> options) : base(options)
        { }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}