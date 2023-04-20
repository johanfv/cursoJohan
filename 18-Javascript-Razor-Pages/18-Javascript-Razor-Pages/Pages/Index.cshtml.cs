using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _18_Javascript_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {

        public string Name { get; set; }

        public void OnGet()
        {
            Name = "Johan";
        }
    }
}