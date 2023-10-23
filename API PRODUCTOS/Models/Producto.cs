﻿using System.ComponentModel.DataAnnotations;

namespace API_PRODUCTOS.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]

        public int Cantidad { get; set; }

    }
}
