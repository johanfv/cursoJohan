using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _19_jQuery_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public string nombre { get; set; }
        public void OnGet()
        {
            nombre = "Adalberto";
        }
    }
}