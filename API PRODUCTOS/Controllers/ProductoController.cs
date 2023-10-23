﻿using API_PRODUCTOS.Data;
using API_PRODUCTOS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_PRODUCTOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly AplicationDBContext _db;
        public ProductoController(AplicationDBContext db)
        {
            _db = db;
        }


        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Producto> products = await _db.Producto.ToListAsync();
            return Ok(products);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{IdProducto}")]
        public async Task<IActionResult> Get(int IdProducto)
        {
            Producto producto = await _db.Producto.FirstOrDefaultAsync(x=> x.IdProducto == IdProducto);
            if (producto == null)
            {
                return BadRequest();
            }
            return Ok(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            Producto producto2 = await _db.Producto.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);


            if (producto2==null && producto != null )
            {
                await _db.Producto.AddAsync(producto);
                await _db.SaveChangesAsync();
                Ok(producto);
            }
            return BadRequest("El objeto ya existe");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{IdProducto}")]
        public async Task<IActionResult> Put(int IdProducto, [FromBody] Producto producto)
        {
            Producto producto2 = await _db.Producto.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);
            if (producto2!= null)
            {
                producto2.Nombre = producto.Nombre != null ? producto.Nombre:producto2.Nombre;
                producto2.Descripcion = producto.Descripcion != null ? producto.Descripcion : producto2.Descripcion;
                producto2.Cantidad = producto.Cantidad != null ? producto.Cantidad : producto2.Cantidad;
                _db.Producto.Update(producto2);
                await _db.SaveChangesAsync();
                return Ok();

            }
            return BadRequest("El objeto no existe");

        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdProducto}")]
        public async Task<IActionResult>  Delete(int IdProducto)
        {
            Producto producto = await _db.Producto.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                _db.Remove(producto);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest();

        }
    }
}
