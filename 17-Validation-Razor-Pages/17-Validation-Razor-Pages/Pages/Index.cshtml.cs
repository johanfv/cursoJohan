using _17_Validation_Razor_Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17_Validation_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Person Person { get; set; }
        [ViewData]
        public string Message { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                
                return Page();
            }

            Message = "Validaciones correctas";
            return Page();

        }
    }
}