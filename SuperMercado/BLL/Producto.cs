using BE;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class Producto
    {
        private List<BE.Producto> temporal = new List<BE.Producto>();
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

        public int Update(BE.Producto pr)
        {
            return new MapperProducto().Update(pr);
        }

        public List<BE.Producto> CrearProductosTemporal()
        {
            temporal = getProductos();
            return temporal;
        }

        public bool CompararStock(int cantidad, int productId)
        {
            BE.Producto producto = temporal.Where(p => p.Id == productId).First();
            if (producto.Stock < cantidad)
                return false;
            else
                return true;
        }

        public BE.Producto GetByIdTemporal(int id)
        {
            return temporal.Where(p => p.Id == id).First();
        }

        public List<BE.Producto> GetProductosTemporal()
        {
            return temporal;
        }
        
        public void RestarStock(int cantidad, int id)
        {
            BE.Producto p = GetByIdTemporal(id);
            p.Stock = p.Stock - cantidad;
        }

    }
}
