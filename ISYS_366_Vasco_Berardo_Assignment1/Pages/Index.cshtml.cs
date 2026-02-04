using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISYS_366_Vasco_Berardo_Assignment1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("OnGet method called");
        }
    }
}
