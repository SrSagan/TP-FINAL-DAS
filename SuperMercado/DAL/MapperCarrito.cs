using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperCarrito
    {
        private readonly Acceso acceso = new Acceso();
        public List<Carrito> getCarritos()
        {
            DataTable dt = acceso.Leer("sp_getCarritos", null);
            List<Carrito> carritos = new List<Carrito>();
            foreach (DataRow row in dt.Rows)
            {
                Carrito carrito = new Carrito()
                {
                    //falta añadir data
                };
                carritos.Add(carrito);
            }
            return carritos;
        }
    }
}
