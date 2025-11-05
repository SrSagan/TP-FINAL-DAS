using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperCliente
    {
        private readonly Acceso acceso = new Acceso();
        public List<Cliente> getClientes()
        {
            DataTable dt = acceso.Leer("sp_getClientes", null);
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow row in dt.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    //falta añadir data
                };
                clientes.Add(cliente);
            }
            return clientes;
        }
    }
}
