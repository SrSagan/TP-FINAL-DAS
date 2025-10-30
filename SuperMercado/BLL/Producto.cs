using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Producto
    {
        public List<BE.Producto> getProductos()
        {
            return new MapperProducto().getProductos();
        }
    }
}
