using EjemploOracle.DataAccess.Models;
using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using System.Text;

namespace EjemploOracle.Razor.Pages.Categoria
{
    public class CategoriaUpdateModel : PageModel
    {
        CategoriaDTO _categoria = new();

        public string NombreCategoria;

        [BindProperty]
        public string Nombre { get; set; }
        
        public async Task OnGet()
        {
           var id= Request.Query["idCategoria"];
            var apiUrl = $"https://localhost:7169/api/Categoria/{id}";
            using HttpClient httpClient = new();
            var response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<CategoriaDTO>(json);
                _categoria = data;
             }
            NombreCategoria = _categoria.Nombre;
        }

        public async Task UpdateCategoria()
        {
            string id = Request.Query["idCategoria"];
            //string idCategoria = Request. ["idCategoria"];

        }

        public async Task OnPost()
        {
            //await InsertarCategoria(Request.Form["nombre"]);
            //newCategoria.Nombre = Request.Form["newCategoria.Nombre"];
            await InsertarCategoria(Nombre);
        }



        private async Task InsertarCategoria(string nombre)
        {
            Categorium newCategoria = new ();
            newCategoria.Nombre = nombre;

            var jcategoria = JsonSerializer.Serialize(newCategoria);

            var apiUrl = "https://localhost:7169/api/Categoria";

            using HttpClient httpClient = new();            
                var requestContent = new StringContent(jcategoria, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, requestContent);
                response.EnsureSuccessStatusCode();
            
        }
    }
}
