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
                    new BE.OrdenDeCompra(new DAL.Mappers.MapperPedido().GetByFacId((int)row["Id"]))
                    );
                factura.PrecioTotal = float.Parse(row["PrecioTotal"].ToString());
                factura.Id = (int)row["Id"];
                facturas.Add(factura);
            }
            return facturas;
        }
        public List<Factura> GetAllByID(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);
            DataTable dt = acceso.Leer("sp_Factura_GetAllByID", parameters);
            List<Factura> facturas = new List<Factura>();
            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new Factura(
                    new MapperUsuario().GetById((int)row["UsuarioId"]),
                    new BE.OrdenDeCompra(new DAL.Mappers.MapperPedido().GetByFacId((int)row["Id"]))
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
        public void GenerarXml(string ruta, int dni)
        {
            List<Factura> facturas = GetAll();
            DataSet ds = new DataSet("FacturasDataSet");

            DataTable dtFactura = new DataTable("Factura");
            dtFactura.Columns.Add("Id", typeof(int));
            dtFactura.Columns.Add("UsuarioNombre", typeof(string));
            dtFactura.Columns.Add("Mail", typeof(string));
            dtFactura.Columns.Add("DNI", typeof(int));
            dtFactura.Columns.Add("PrecioTotal", typeof(float));

            DataTable dtPedidos = new DataTable("Pedido");
            dtPedidos.Columns.Add("FacturaId", typeof(int));
            dtPedidos.Columns.Add("ProductoNombre", typeof(string));
            dtPedidos.Columns.Add("Cantidad", typeof(int));
            dtPedidos.Columns.Add("Precio", typeof(float));

            foreach (var fac in facturas)
            {
                if(fac.Cliente.Dni == dni)
                {
                    DataRow rowF = dtFactura.NewRow();
                    rowF["Id"] = fac.Id;
                    rowF["UsuarioNombre"] = fac.Cliente.Nombre + " " + fac.Cliente.Apellido;
                    rowF["Mail"] = fac.Cliente.Mail;
                    rowF["DNI"] = (int)fac.Cliente.Dni;
                    rowF["PrecioTotal"] = fac.PrecioTotal;
                    dtFactura.Rows.Add(rowF);

                    List<BE.Pedido> pedidos = new DAL.Mappers.MapperPedido().GetByFacId(fac.Id);

                    foreach (var pedido in pedidos)
                    {
                        DataRow rowP = dtPedidos.NewRow();
                        rowP["FacturaId"] = fac.Id;
                        rowP["ProductoNombre"] = pedido.Producto.Nombre;
                        rowP["Cantidad"] = pedido.Cantidad;
                        rowP["Precio"] = pedido.Precio;
                        dtPedidos.Rows.Add(rowP);
                    }
                }
            }

            ds.Tables.Add(dtFactura);
            ds.Tables.Add(dtPedidos);

            DataRelation rel = new DataRelation(
                "Factura_Pedidos",
                dtFactura.Columns["Id"],
                dtPedidos.Columns["FacturaId"]
            );

            ds.Relations.Add(rel);

            rel.Nested = true;

            ds.WriteXml(ruta);
        }

    }
}
