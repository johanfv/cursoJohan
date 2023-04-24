using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Text;
using System.Text.Json;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaDeleteModel : PageModel
    {
        [BindProperty]
        public CategoriaDTO _categoriaD { get; set; }

        public async Task OnGet()
        {
            var id = Request.Query["idCategoria"];
            var apiUrl = $"https://localhost:7169/api/Categoria/{id}";
            using HttpClient httpClient = new();
            var response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<CategoriaDTO>(json);
                _categoriaD = data;
            }
        }

        public async Task OnPost()
        {
            var jcategoria = JsonSerializer.Serialize(_categoriaD);

            

            using HttpClient httpClient = new();
            var requestContent = new StringContent(jcategoria, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(apiUrl, requestContent);
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();

            }
            else
            {

            }
        }

        public IActionResult OnPost([FromBody]idCategoria idCategoria)
        {
            var apiUrl = $"https://localhost:7169/api/Categoria/{idCategoria}";

            using HttpClient httpClient = new();
            var requestContent = new StringContent(_cat, Encoding.UTF8, "application/json");

            var response = httpClient.DeleteAsync(apiUrl, requestContent);
            if (response.IsSuccessStatusCode)
         
        }
    }
}
