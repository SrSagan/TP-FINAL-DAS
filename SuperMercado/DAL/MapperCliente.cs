using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MapperCliente : ICRUD<Cliente>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            DataTable dt = acceso.Leer("sp_getClientes", null);
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow row in dt.Rows)
            {
                Cliente cliente = new Cliente(id: (int)row["id"],nombre: (string)row["Nombre"], apellido: (string)row["Apellido"],
                    dni: (int)row["Dni"], mail: (string)row["Mail"], password: (string)row["Password"], carrito: (Carrito)row["Carrito"]);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public Cliente GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Cliente entity)
        {
            throw new System.NotImplementedException();
        }


        /*public List<Cliente> getClientes()
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
        }*/
    }
}
