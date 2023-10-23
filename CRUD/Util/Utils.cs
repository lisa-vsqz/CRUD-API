using CRUD.Models;

namespace CRUD.Util
{
    public class Utils
    {

        public static List<Producto> listaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Prod1",
                Descripcion = "Desc1",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "Prod2",
                Descripcion = "Desc2",
                Cantidad = 2
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "Prod3",
                Descripcion = "Desc3",
                Cantidad = 3
            },
            new Producto()
            {
                IdProducto = 4,
                Nombre = "Prod4",
                Descripcion = "Desc4",
                Cantidad = 4
            },
        };
    }
}
