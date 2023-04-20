using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15_ProcessPost_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]// este atributo se utiliza para simplificar el proceso de vinculacion de datos entre el PageModel y un formulario
    public string Name { get; set; }
        [BindProperty]
    public int Age { get; set; }
    public bool IsAdult { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if(Age >= 18)
            {
                IsAdult = true;
            } else
            {
                IsAdult = false;
            }
        }
    }
}