using FontanezPizzeria.Data;
using FontanezPizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FontanezPizzeria.Pages.Checkout;

[BindProperties(SupportsGet = true)]
public class Checkout : PageModel
{
    
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string ImageTitle { get; set; }

    private readonly ApplicationDbContext _context;
    public Checkout(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }

        if (string.IsNullOrWhiteSpace(ImageTitle))
        {
            ImageTitle = "Create";
        }

        PizzaOrderModel pizzaOrder = new PizzaOrderModel();
        pizzaOrder.PizzaName = PizzaName;
        pizzaOrder.BasePrice = PizzaPrice;

        _context.PizzaOrders.Add(pizzaOrder);
        _context.SaveChanges();
    }
}