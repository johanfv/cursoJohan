using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _22_AJAX_Razor_Pages_AAAAAAA.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public JsonResult OnGetData()
        {
            var data = new { name = "johan", age = 28 };///crear un objeto que se utilizara como json
            return new JsonResult(data); 
        }
    }
}