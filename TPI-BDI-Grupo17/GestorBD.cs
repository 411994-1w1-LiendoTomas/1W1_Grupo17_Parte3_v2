using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TPI_BDI_Grupo17
{
    public static class GestorBD
    {
        // Conexión Tomás:
        //private static string cadenaConexion = @"Data Source=DESKTOP-R6HLHK7\SQLEXPRESS;Initial Catalog=BDD_Grupo17;Integrated Security=True;";
        private static string cadenaConexion = @"Data Source=.\sqlexpress;Initial Catalog=BDD_Grupo17;Integrated Security=True;";

        // Conexión Franco:

        // Conexión Federico:

        // Conexión Ignacio:

        public static DataTable EjecutarSP(string nombreSP, List<SqlParameter> parametros)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection cnn = new SqlConnection(cadenaConexion))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(nombreSP, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if(parametros != null)
                        {
                            cmd.Parameters.AddRange(parametros.ToArray());
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            return dt;
        }
    }
}
