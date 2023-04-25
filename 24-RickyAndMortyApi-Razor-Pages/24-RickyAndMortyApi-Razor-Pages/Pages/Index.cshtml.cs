using _24_RickyAndMortyApi_Razor_Pages.DTO;
using _24_RickyAndMortyApi_Razor_Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace _24_RickyAndMortyApi_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        
        List<Character> Characters { get; set; }
        public async Task OnGet()
        {
            var apiUrl = "https://rickandmortyapi.com/api/character";
            using HttpClient client = new();
            var response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<RickAndMortyDataDTO>(json);
            }
        }
    }
}