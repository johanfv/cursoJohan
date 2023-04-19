using EjemploOracle.vistas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace EjemploOracle.vistas.Controllers { 

    public class HomeController : Controller
    {
        // private readonly CategoriaService servicioApi;



        
        public async Task<IActionResult> Index()
        {
            List<CategoriaDTO> listaCategoria = new List<CategoriaDTO>();
//            var apiUrl = "https://localhost:7169/api/Categoria";
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

            return View(listaCategoria);

        }

        public IActionResult modificar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}

