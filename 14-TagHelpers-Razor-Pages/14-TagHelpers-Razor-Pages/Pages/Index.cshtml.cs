using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_TagHelpers_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public Movie Movie { get; set; }    
        public void OnGet()
        {
            Movie = new Movie 
            {
                Id = 1,
                Title = "Godzilla X Kong",
                Genre = "Accion"
            };
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
    }
    }
