using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Cliente
    {
        public List<BE.Cliente> getClientes()
        {
            return new MapperCliente().getClientes();
        }
    }
}
