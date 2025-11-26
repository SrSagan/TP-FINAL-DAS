using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MapperUsuario : ICRUD<Usuario>
    {
        private readonly Acceso acceso = new Acceso();
        public int Create(Usuario entity)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            Console.WriteLine(entity.Password);
            parameters[0] = new SqlParameter("@Nombre", entity.Nombre);
            parameters[1] = new SqlParameter("@Apellido", entity.Apellido);
            parameters[2] = new SqlParameter("@Dni", entity.Dni);
            parameters[3] = new SqlParameter("@Mail", entity.Mail);
            parameters[4] = new SqlParameter("@Password", entity.Password);
            parameters[5] = new SqlParameter("@Familia", entity.Familia);

            return acceso.Escribir("sp_Usuario_Create", parameters);
        }

        public int Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            return acceso.Escribir("sp_Usuario_Delete", parameters);
        }

        public List<Usuario> GetAll()
        {
            DataTable dt = acceso.Leer("sp_Usuario_GetAll", null);
            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in dt.Rows)
            {
                Usuario usr = new Usuario( 
                    row["Nombre"].ToString(), 
                    row["Apellido"].ToString(), 
                    (int)row["Dni"], 
                    row["Mail"].ToString(), 
                    row["Password"].ToString(), 
                    (int)row["Familia"]
                    );
                usr.Id = (int)row["Id"];
                usuarios.Add(usr);
            }
            return usuarios;
        }

        public Usuario GetById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", id);

            DataTable dt = acceso.Leer("sp_Usuario_GetById", parameters);

            DataRow row = dt.Rows[0];
            Usuario usr = new Usuario(
            row["Nombre"].ToString(),
            row["Apellido"].ToString(),
            (int)row["Dni"],
            row["Mail"].ToString(),
            row["Password"].ToString(),
            (int)row["Familia"]
            );
            usr.Id = id;
               
            return usr;
        }
        public Usuario GetByMail(string mail)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Mail", mail);

            DataTable dt = acceso.Leer("sp_Usuario_GetByMail", parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            Usuario usr = new Usuario(
            row["Nombre"].ToString(),
            row["Apellido"].ToString(),
            (int)row["Dni"],
            row["Mail"].ToString(),
            row["Password"].ToString(),
            (int)row["Familia"]
            );
            usr.Id = (int)row["Id"];

            return usr;
        }
        public int Update(Usuario entity)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@Id", entity.Id);
            parameters[1] = new SqlParameter("@Nombre", entity.Nombre);
            parameters[2] = new SqlParameter("@Apellido", entity.Apellido);
            parameters[3] = new SqlParameter("@Dni", entity.Dni);
            parameters[4] = new SqlParameter("@Mail", entity.Mail);
            parameters[5] = new SqlParameter("@Password", entity.Password);
            parameters[6] = new SqlParameter("@Familia", entity.Familia);

            return acceso.Escribir("sp_Usuario_Update", parameters);
        }
    }
}
