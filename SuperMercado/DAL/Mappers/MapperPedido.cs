using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL.Mappers
{
    public class MapperPedido
    {
        private readonly Acceso acceso = new Acceso();
        public int Create(Pedido entity, int OrdenDeCompra)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@Producto", entity.Producto.Id);
            parameters[1] = new SqlParameter("@Cantidad", entity.Cantidad);
            parameters[2] = new SqlParameter("@OrdenDeCompra", OrdenDeCompra);

            return acceso.Escribir("sp_Pedido_Create", parameters);
        }

        public int Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            return acceso.Escribir("sp_Pedido_Delete", parameters);
        }

        public List<Pedido> GetAll()
        {
            DataTable dt = acceso.Leer("sp_Pedido_GetAll", null);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (DataRow row in dt.Rows)
            {
                Pedido pedido = new Pedido(
                    (int)row["Id"],
                    new MapperProducto().GetById((int)row["Producto"]),
                    (int)row["Cantidad"]
                    );
                pedidos.Add(pedido);
            }
            return pedidos;
        }

        public Pedido GetById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            DataTable dt = acceso.Leer("sp_Pedido_GetById", parameters);

            DataRow row = dt.Rows[0];
            Pedido pedido = new Pedido(
                    (int)row["Id"],
                    new MapperProducto().GetById((int)row["Producto"]),
                    (int)row["Cantidad"]
                    );

            return pedido;
        }

        public int Update(Pedido entity, int OrdenDeCompra)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@Producto", entity.Producto.Id);
            parameters[2] = new SqlParameter("@Cantidad", entity.Cantidad);
            parameters[3] = new SqlParameter("@OrdenDeCompra", OrdenDeCompra);

            return acceso.Escribir("sp_Pedido_Update", parameters);
        }
    }
}
