using FontanezPizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FontanezPizzeria.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public void OnGet()
    {
        
    }
}