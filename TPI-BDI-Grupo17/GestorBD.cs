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

        public static DataTable GetPeoresDias(DateTime desde, DateTime hasta)
        {
            // normalizamos fechas (sin hora)
            desde = desde.Date;
            hasta = hasta.Date;

            const string sql = @"
            SELECT Dia, Valor_Metrica, Tipo_Metrica, Clasificacion_Dia, Pelicula_Mas_Vista
            FROM (
                SELECT TOP 3
                    CAST(f.dia AS date) AS Dia,
                    CAST(SUM(e.precio_base) AS decimal(18,2)) AS Valor_Metrica,
                    'Recaudación' AS Tipo_Metrica,
                    'Peor Día'   AS Clasificacion_Dia,
                    (
                        SELECT TOP 1 p2.nombre
                        FROM Funciones f2
                        JOIN Entradas e2 ON e2.id_funcion = f2.id
                        JOIN Peliculas p2 ON p2.id = f2.id_pelicula
                        WHERE CAST(f2.dia AS date) = CAST(f.dia AS date)
                        GROUP BY p2.nombre
                        ORDER BY COUNT(e2.id) DESC
                    ) AS Pelicula_Mas_Vista
                FROM Funciones f
                JOIN Entradas e ON e.id_funcion = f.id
                WHERE CAST(f.dia AS date) BETWEEN @desde AND @hasta
                GROUP BY CAST(f.dia AS date)
                ORDER BY SUM(e.precio_base) ASC
            ) AS R1

            UNION ALL

            SELECT Dia, Valor_Metrica, Tipo_Metrica, Clasificacion_Dia, Pelicula_Mas_Vista
            FROM (
                SELECT TOP 3
                    CAST(f.dia AS date) AS Dia,
                    CAST(COUNT(e.id) AS decimal(18,2)) AS Valor_Metrica,
                    'Entradas Vendidas' AS Tipo_Metrica,
                    'Peor Día'          AS Clasificacion_Dia,
                    (
                        SELECT TOP 1 p2.nombre
                        FROM Funciones f2
                        JOIN Entradas e2 ON e2.id_funcion = f2.id
                        JOIN Peliculas p2 ON p2.id = f2.id_pelicula
                        WHERE CAST(f2.dia AS date) = CAST(f.dia AS date)
                        GROUP BY p2.nombre
                        ORDER BY COUNT(e2.id) DESC
                    ) AS Pelicula_Mas_Vista
                FROM Funciones f
                JOIN Entradas e ON e.id_funcion = f.id
                WHERE CAST(f.dia AS date) BETWEEN @desde AND @hasta
                GROUP BY CAST(f.dia AS date)
                ORDER BY COUNT(e.id) ASC
            ) AS R2

            ORDER BY Dia, Tipo_Metrica;";


            var dt = new DataTable();
            using (var cn = new SqlConnection(cadenaConexion))
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.Add(new SqlParameter("@desde", SqlDbType.Date) { Value = desde });
                da.SelectCommand.Parameters.Add(new SqlParameter("@hasta", SqlDbType.Date) { Value = hasta });
                da.Fill(dt);
            }
            return dt;
        }

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
