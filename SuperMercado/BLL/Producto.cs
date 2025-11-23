using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Producto
    {
        public List<BE.Producto> getProductos()
        {
            return new MapperProducto().GetAll();
        }
        public int Create(BE.Producto pr)
        {
            return new MapperProducto().Create(pr);
        }

        public BE.Producto GetById(int id)
        {
            return new MapperProducto().GetById(id);
        }
    }
}
