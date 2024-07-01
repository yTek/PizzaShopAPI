namespace PizzaShopAPI.Models;

public class Pizza
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
}