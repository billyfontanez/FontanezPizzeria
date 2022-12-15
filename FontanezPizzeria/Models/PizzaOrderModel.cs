using Microsoft.AspNetCore.Authentication;

namespace FontanezPizzeria.Models;

public class PizzaOrderModel
{
    public int Id { get; set; }
    public string PizzaName{ get; set; }
    public float BasePrice { get; set; }
}