using EjemploOracle.DataAccess.Models;
using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using System.Text;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaInsertModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public Categorium newCategoria { get; set; }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            //await InsertarCategoria(Request.Form["nombre"]);
            //newCategoria.Nombre = Request.Form["newCategoria.Nombre"];
            await InsertarCategoria();
        }


        private async Task InsertarCategoria()
        {
            
            var jcategoria = JsonSerializer.Serialize(newCategoria);

            var apiUrl = "https://localhost:7169/api/Categoria";

            using HttpClient httpClient = new();            
                var requestContent = new StringContent(jcategoria, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, requestContent);
                response.EnsureSuccessStatusCode();
            
        }
    }
}
