using EjemploOracle.DataAccess.Models;
using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaUpdatesModel : PageModel
    {
        [BindProperty]
        public CategoriaDTO _categoria { get; set; }

        public bool _valid = false;
        public string Message = "";

        public async Task OnGet()
        {
            var id = Request.Query["idCategoria"];
            var nocliente = Request.Query["nocliente"];
            var apiUrl = $"https://localhost:7169/api/Categoria/{id}";
            using HttpClient httpClient = new();
            var response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<CategoriaDTO>(json);
                _categoria = data;
            }
        }

        /*  */
        public async Task OnPost()
        {
            await InsertarCategoria();
        }

        private async Task InsertarCategoria()
        {
           
            var jcategoria = JsonSerializer.Serialize(_categoria);

            var apiUrl = "https://localhost:7169/api/Categoria";

            using HttpClient httpClient = new();
            var requestContent = new StringContent(jcategoria, Encoding.UTF8, "application/json");
            
            var response = await httpClient.PutAsync(apiUrl, requestContent);
            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                _valid = true;
                Message = "Categoría Modificada correctamente";
            }
            else
            {
                Message = "No se modificó la categoria";
            }
            
        }
    }
}
