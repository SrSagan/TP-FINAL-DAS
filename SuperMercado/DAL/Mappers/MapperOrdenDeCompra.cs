using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL.Mappers
{
    public class MapperOrdenDeCompra
    {
        /*private readonly Acceso acceso = new Acceso();

        public int Create(OrdenDeCompra entity, int Factura)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@FacturaId", Factura);

            return acceso.Escribir("sp_OrdenDeCompra_Create", parameters);
        }

        public int Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            return acceso.Escribir("sp_OrdenDeCompra_Delete", parameters);
        }

        public List<OrdenDeCompra> GetAll()
        {
            DataTable dt = acceso.Leer("sp_OrdenDeCompra_GetAll", null);
            List<OrdenDeCompra> ordenDeCompras = new List<OrdenDeCompra>();
            foreach (DataRow row in dt.Rows)
            {
                OrdenDeCompra ordenDeCompra = new OrdenDeCompra(
                    (int)row["Id"],
                    new List<Pedido> { }
                    );
                ordenDeCompras.Add(ordenDeCompra);
            }
            return ordenDeCompras;
        }

        public OrdenDeCompra GetById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            DataTable dt = acceso.Leer("sp_Producto_GetById", parameters);

            DataRow row = dt.Rows[0];
            OrdenDeCompra ordenDeCompra = new OrdenDeCompra(
                    (int)row["Id"],
                    new List<Pedido> { }
                    );

            return ordenDeCompra;
        }

        public int Update(OrdenDeCompra entity, int FacturaId)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@FacturaId", FacturaId);

            return acceso.Escribir("sp_OrdenDeCompra_Update", parameters);
        }*/
    }
}
