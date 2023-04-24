using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _23_PartialViews_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {

        public List<string> Animals = new List<string>();

        public void OnGet()
        {
            Animals.AddRange(new[]
           {
                "Perro",
                "Gato",
                "Caballo",
                "Tigre"
           });
        }
    }
}