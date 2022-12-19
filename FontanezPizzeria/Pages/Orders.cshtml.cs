using FontanezPizzeria.Data;
using FontanezPizzeria.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FontanezPizzeria.Pages;

public class Orders : PageModel
{
    public List<PizzaOrderModel> PizzaOrderModels = new List<PizzaOrderModel>();
    
    private readonly ApplicationDbContext _context;
    

    public Orders(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        PizzaOrderModels = _context.PizzaOrders.ToList();
    }
}