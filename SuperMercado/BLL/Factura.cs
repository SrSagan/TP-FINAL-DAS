using DAL;
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
        public List<BE.Factura> getFacturas()
        {
            return new DAL.MapperFactura().GetAll();
        }
        public List<BE.Factura> getFacturasByID(int id)
        {
            return new DAL.MapperFactura().GetAllByID(id);
        }
        public BE.Factura GetLast()
        {
            return new DAL.MapperFactura().GetLast();
        }
        public void GenerarXml(string ruta, int dni)
        {
            new DAL.MapperFactura().GenerarXml(ruta, dni);
        }
    }
}
