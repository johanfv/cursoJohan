using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _13_CodeBehind_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public string Name;
        public int Age { get; set; }
        public void OnGet()
        {
            Name = "Leon Messi";
            Age = 35;
        }
    }
}