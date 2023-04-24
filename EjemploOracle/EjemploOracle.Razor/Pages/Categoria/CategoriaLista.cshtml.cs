using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace EjemploOracle.Razor.Pages.Categoria
{
    
    public class CategoriaListaModel : PageModel
    {
        public List<CategoriaDTO> liCategoria = new();
        public async Task OnGet()
        {
            var apiUrl = "https://localhost:7169/api/Categoria";
            using HttpClient httpClient = new();
            
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                    liCategoria = data;
                }
            
        }
        public IActionResult OnPost()
        {
           return RedirectToPage("/Categoria/CategoriaUpdate");
        }
    }
}
