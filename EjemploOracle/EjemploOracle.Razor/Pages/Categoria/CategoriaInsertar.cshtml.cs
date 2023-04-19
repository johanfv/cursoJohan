using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaInsertarModel : PageModel
    {
         public CategoriaDTO newCategoria = new CategoriaDTO();
        public void OnGet()
        {
            
        }

        [HttpPost]
        public async Task OnPost() 
        {
            await InsertarCategoria(Request.Form["nombre"]);

        }

        private async Task InsertarCategoria(string nombre)
        {
            //request.Form["nombre"]
            newCategoria.Nombre = "ARTICULOS DE COCINA";

            var categoria = JsonSerializer.Serialize(newCategoria);

            var apiUrl = "https://localhost:7169/api/Categoria";

            using (var httpClient = new HttpClient())
            {
                var requestContent = new StringContent(categoria, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, requestContent);
                response.EnsureSuccessStatusCode();

            }
        }
    }
}
