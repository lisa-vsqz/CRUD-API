using CRUD.Models;
using CRUD.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CRUD.Controllers
{
    public class ProductoController : Controller
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5261";

        public ProductoController()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_apiBaseUrl)
            };
        }

        // GET: ProductoController
        public async Task<IActionResult> Index()
        {
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync("http://localhost:5261/api/Producto");
            //var responsejson = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responsejson);
            //return View(Util.Utils.listaProducto);
            var productos = await _httpClient.GetFromJsonAsync<List<Producto>>("api/Producto");
            return View(productos);
        }

        // GET: ProductoController/Details/5
        public async Task<IActionResult> Details(int IdProducto)
        {
            //Producto producto = Util.Utils.listaProducto.Find(x => x.IdProducto == IdProducto);
            var producto = await _httpClient.GetFromJsonAsync<Producto>($"api/Producto/{IdProducto}");
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {

            //int id = Util.Utils.listaProducto.Count() + 1;
            //producto.IdProducto = id;
            //Util.Utils.listaProducto.Add(producto);
            await _httpClient.PostAsJsonAsync("api/Producto", producto);
            return RedirectToAction("Index");
        }



        // GET: ProductoController/Edit/5
        public async Task<IActionResult> Edit(int IdProducto)
        {
            //Producto producto = Util.Utils.listaProducto.Find(x => x.IdProducto == IdProducto);
            var producto = await _httpClient.GetFromJsonAsync<Producto>($"api/Producto/{IdProducto}");
            
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Producto producto)
        {
            //Producto productoo = Util.Utils.listaProducto.Find(x => x.IdProducto == producto.IdProducto);
            //if (producto != null)
            //{
            //    productoo.Nombre = producto.Nombre;
            //    productoo.Cantidad = producto.Cantidad;
            //    productoo.Descripcion = producto.Descripcion;
            await _httpClient.PutAsJsonAsync($"api/Producto/{producto.IdProducto}", producto);
            return RedirectToAction("Index");

            //}

            //return View();
        }


        // GET: ProductoController/Delete/5
        public async Task<IActionResult> Delete(int IdProducto)
        {
            //Producto producto = Util.Utils.listaProducto.Find(x => x.IdProducto == IdProducto);
            //if (producto != null)
            //{
            //    Util.Utils.listaProducto.Remove(producto);
            //}
            await _httpClient.DeleteAsync($"/api/Producto/{IdProducto}");
            return RedirectToAction("Index");
        }

        
    }
}
