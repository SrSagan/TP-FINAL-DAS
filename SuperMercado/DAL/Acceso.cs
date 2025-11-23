using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void Conectar()
        {
            cn.ConnectionString = "Data Source=elcongresorol.duckdns.org,55879;Initial Catalog=Supermercado;Persist Security Info=True;User ID=Sa;Password=Kbo43462052!!;Encrypt=False";
            cn.Open();
        }
        private void Desconectar()
        {
            cn.Close();
            cn.Dispose();
        }
        public int Escribir(string sp, SqlParameter[] arguments)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                Conectar();

                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (arguments != null)
                    cmd.Parameters.AddRange(arguments);

                sqlTransaction = cn.BeginTransaction();
                cmd.Transaction = sqlTransaction;
                int rows = cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                return rows;
            }
            catch (Exception ex)
            {
                if (sqlTransaction != null)
                    sqlTransaction.Rollback();
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                sqlTransaction = null;
                Desconectar();
            }
        }
        public DataTable Leer(string sp, SqlParameter[] arguments)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                Conectar();

                cmd.Parameters.Clear();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (arguments != null)
                    cmd.Parameters.AddRange(arguments);
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                Desconectar();
            }
        }
    }
}
