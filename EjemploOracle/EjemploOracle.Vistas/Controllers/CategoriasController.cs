using EjemploOracle.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EjemploOracle.Vistas.Controllers
{
    public class CategoriasController : Controller
    {
        public async Task<IActionResult> ListarCategorias()
        {
            List<CategoriaDTO> ListaCategoria = new List<CategoriaDTO>();
            var apiUrl = "https://localhost:7180/api/Categoria";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                    ListaCategoria = data;
                }
            }

            return View(ListaCategoria);
        }
    }
}
