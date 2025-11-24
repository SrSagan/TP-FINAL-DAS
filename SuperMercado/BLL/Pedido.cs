using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pedido
    {
        public int Create(BE.Pedido pedido, int facturaId)
        {
            return new DAL.Mappers.MapperPedido().Create(pedido, facturaId);
        }
    }
}
