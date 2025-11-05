using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperProducto : ICRUD<Producto>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Producto entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Producto> getAll()
        {
            DataTable dt = acceso.Leer("sp_getProductos", null);
            List<Producto> productos = new List<Producto>();
            foreach (DataRow row in dt.Rows)
            {
                Producto producto = new Producto(
                    id: (int)row["id"],
                    nombre: (string)row["Nombre"],
                    precio: (float)row["Precio"]
                    );
                productos.Add(producto);
            }
            return productos;
        }

        public List<Producto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Producto GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Producto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
