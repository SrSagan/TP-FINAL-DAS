using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Carrito
    {
        public List<BE.Carrito> getCarritos()
        {
            return new MapperCarrito().getCarritos();
        }
    }
}
