using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _16_ClassTransferData_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [ViewData]
        public string Message { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public void OnGet()
        {
            ViewData["MyString"] = "Cadena de text";
            ViewData["Mynumber"] = 100;

            Message = "Hello World!";
        }

        public IActionResult OnPost()
        {
            //Almacenar en TempData el valor Name que viene del formulario
            //Para mostrarlo en una redirección
            TempData["NameTempData"] = Name;
            return RedirectToPage("/Privacy");
        }
    }
}