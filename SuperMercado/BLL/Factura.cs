using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Factura
    {
        public int Create(BE.Factura fac)
        {
            return new DAL.MapperFactura().Create(fac);
        }

        public BE.Factura GetLast()
        {
            return new DAL.MapperFactura().GetLast();
        }
    }
}
