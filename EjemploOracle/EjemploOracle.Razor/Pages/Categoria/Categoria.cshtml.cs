using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using EjemploOracle.DTO;
using System.Reflection;
using Microsoft.VisualBasic;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaModel : PageModel
    {
        public List<CategoriaDTO> listaCategoria = new List<CategoriaDTO>();
        public string nombre;
        public string variable;
        
        public async Task OnGet()
        {
            nombre = "Johan Fonseca";
            await traer();
            
        }

        public async Task traer() 
        {
            var apiUrl = "http://localhost:5298/api/Categoria";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);

                    listaCategoria = data;
                }
            }
        }

    }
}


