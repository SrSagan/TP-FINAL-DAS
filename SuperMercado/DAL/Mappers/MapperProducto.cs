using BE;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MapperProducto : ICRUD<Producto>
    {
        private readonly Acceso acceso = new Acceso();

        public int Create(Producto entity)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@Nombre", entity.Nombre);
            parameters[2] = new SqlParameter("@Precio", entity.Precio);
            parameters[3] = new SqlParameter("@Stock", entity.Stock);

            return acceso.Escribir("sp_Producto_Create", parameters);
        }

        public int Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            return acceso.Escribir("sp_Producto_Delete", parameters);
        }

        public List<Producto> GetAll()
        {
            DataTable dt = acceso.Leer("sp_Producto_GetAll", null);
            List<Producto> productos = new List<Producto>();
            foreach (DataRow row in dt.Rows)
            {
                Producto producto = new Producto(
                    (int)row["Id"],
                    row["Nombre"].ToString(),
                    (float)row["Precio"],
                    (int)row["Stock"]
                    );
                productos.Add(producto);
            }
            return productos;
        }

        public Producto GetById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            DataTable dt = acceso.Leer("sp_Producto_GetById", parameters);

            DataRow row = dt.Rows[0];
            Producto producto = new Producto(
                    (int)row["Id"],
                    row["Nombre"].ToString(),
                    (float)row["Precio"],
                    (int)row["Stock"]
                    );

            return producto;
        }

        public int Update(Producto entity)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@Nombre", entity.Nombre);
            parameters[2] = new SqlParameter("@Precio", entity.Precio);
            parameters[3] = new SqlParameter("@Stock", entity.Stock);

            return acceso.Escribir("sp_Producto_Update", parameters); ;
        }
    }
}
