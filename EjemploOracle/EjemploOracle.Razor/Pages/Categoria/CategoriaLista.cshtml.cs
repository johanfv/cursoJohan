using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace EjemploOracle.Razor.Pages.Categoria
{
    
    public class CategoriaListaModel : PageModel
    {
        public List<CategoriaDTO> liCategoria = new List<CategoriaDTO>();
        public async Task OnGet()
        {
            var apiUrl = "https://localhost:7169/api/Categoria";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                    liCategoria = data;
                }
            }
        }
    }
}
