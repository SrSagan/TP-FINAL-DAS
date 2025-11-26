using BE;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class MapperFactura : ICRUD<BE.Factura>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Factura entity)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UsuarioId", entity.Cliente.Id);
            parameters[1] = new SqlParameter("@PrecioTotal", entity.PrecioTotal);

            return acceso.Escribir("sp_Factura_Create", parameters);
        }

        public int Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            return acceso.Escribir("sp_Factura_Delete", parameters);
        }

        public List<Factura> GetAll()
        {
            DataTable dt = acceso.Leer("sp_Factura_GetAll", null);
            List<Factura> facturas = new List<Factura>();
            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new Factura(
                    new MapperUsuario().GetById((int)row["UsuarioId"]),
                    new BE.OrdenDeCompra(new List<Pedido> { })
                    );
                factura.PrecioTotal = float.Parse(row["PrecioTotal"].ToString());
                factura.Id = (int)row["Id"];
                facturas.Add(factura);
            }
            return facturas;
        }

        public Factura GetById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            DataTable dt = acceso.Leer("sp_Producto_GetById", parameters);

            DataRow row = dt.Rows[0];
            Factura factura = new Factura(
                    new MapperUsuario().GetById((int)row["UsuarioId"]),
                    new BE.OrdenDeCompra(new List<Pedido> { })
                    );
            factura.Id = id;

            return factura;
        }

        public int Update(Factura entity)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@UsuarioId", entity.Cliente.Id);
            parameters[2] = new SqlParameter("@PrecioTotal", entity.PrecioTotal);

            return acceso.Escribir("sp_Factura_Update", parameters);
        }

        public Factura GetLast()
        {
            DataTable dt = acceso.Leer("sp_Factura_GetLast", null);

            DataRow row = dt.Rows[0];
            Factura factura = new Factura(
                    new MapperUsuario().GetById((int)row["UsuarioId"]),
                    new BE.OrdenDeCompra(new List<Pedido> { })
                    );
            factura.Id = (int)row["Id"];

            return factura;
        }
    }
}
