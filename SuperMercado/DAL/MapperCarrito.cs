using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperCarrito : ICRUD<BE.Carrito>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Carrito entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Carrito> GetAll()
        {
            DataTable dt = acceso.Leer("sp_getCarritos", null);
            List<Carrito> carritos = new List<Carrito>();
            foreach (DataRow row in dt.Rows)
            {
                Carrito carrito = new Carrito(id: (int)row["ID"], productos: new List<Producto>());
                carritos.Add(carrito);
            }
            return carritos;
        }

        public Carrito GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Carrito entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
