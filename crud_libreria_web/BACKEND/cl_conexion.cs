using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crud_libreria_web.BACKEND
{
    public class cl_conexion
    {
        //static SqlConnection conect;
        static SqlConnectionStringBuilder builder;
        static SqlConnection connection;
        public static bool conectar()
        {

            //string conexion = "server = localhost; database = libreria; " + "uid = sa; pwd = TUCOLA.125@;";
            string conexion = "server = localhost; database = libreria; " + "uid = sa; pwd =Futbol.9";
            
            
            try
            {
                //connection = new SqlConnection(builder.ConnectionString);
                connection = new SqlConnection(conexion);
                connection.Open();
                return true;
            }
            catch (Exception) { return false; }
        }
        public static void desconectar()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
        //METODO PARA LOS UPDATE, DELETE EN LA BD
        public static void ejecutarSentencia(SqlCommand comando)
        {
            try
            {
                if (conectar())
                {
                    comando.Connection = connection;
                    comando.ExecuteNonQuery();
                    
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                desconectar();
            }
        }
        //METODO PARA TRAER LA CONSULTA EN UNA TABLA
        public static DataTable ejecutarConsulta(SqlCommand comando)
        {
            if (conectar())
            {
                try
                {
                    comando.Connection = connection;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable resultado_consulta = new DataTable();
                    adaptador.Fill(resultado_consulta);
                    return resultado_consulta;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    desconectar();
                }

            }
            else
            {
                return null;
            }
        }
    }
}