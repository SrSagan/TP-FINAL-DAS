using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperFactura : ICRUD<BE.Factura>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Factura entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Factura> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Factura GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Factura entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
