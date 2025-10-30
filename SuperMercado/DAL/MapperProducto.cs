using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperProducto
    {
        private readonly Acceso acceso = new Acceso();
        public List<Producto> getProductos()
        {
            DataTable dt = acceso.Leer("sp_getProductos", null);
            List<Producto> productos = new List<Producto>();
            foreach (DataRow row in dt.Rows)
            {
                Producto producto = new Producto()
                {
                    //falta añadir data
                };
                productos.Add(producto);
            }
            return productos;
        }
    }
}
