using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_BDI_Grupo17
{
    public partial class FormIgnacioRosso : Form
    {
        public FormIgnacioRosso()
        {
            InitializeComponent();
        }
            private void btnEjecutar_Click(object sender, EventArgs e)
            {
                try
                {
                    // 1. Obtener las fechas de los controles
                    DateTime fechaDesde = dtpFechaDesde.Value.Date;
                    DateTime fechaHasta = dtpFechaHasta.Value.Date;
                    DateTime hoy = DateTime.Today;

                    // --- INICIO DEL BLOQUE DE VALIDACIÓN ---

                    // Regla 1 (Ex-Regla 2): Que "fecha desde" sea menor o IGUAL a "fecha hasta"
                    // Para este reporte, sí permitimos que sean el mismo día.
                    if (fechaDesde > fechaHasta)
                    {
                        MessageBox.Show("La 'Fecha Desde' no puede ser posterior a la 'Fecha Hasta'.",
                                        "Error de Validación",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return; // Detiene la ejecución
                    }

                    // Regla 2 (Ex-Regla 3): Que "fecha hasta" sea como máximo el día de la fecha
                    if (fechaHasta > hoy)
                    {
                        MessageBox.Show("La 'Fecha Hasta' no puede ser un día futuro. Seleccione como máximo el día de hoy.",
                                        "Error de Validación",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return; // Detiene la ejecución
                    }

                    // (Nota: Quitamos la validación de 7 días, no es necesaria aquí)

                    // --- FIN DEL BLOQUE DE VALIDACIÓN ---

                    // 2. Si las validaciones pasan, creamos los parámetros
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@FechaDesde", fechaDesde));
                    parametros.Add(new SqlParameter("@FechaHasta", fechaHasta));

                    // 3. Llamar a la clase GestorDB (que es la misma para todos)
                    DataTable tablaResultados = GestorBD.EjecutarSP("SP_Consulta_Ignacio_Rosso", parametros);

                    // 4. Mostrar los resultados
                    dgvResultados.DataSource = tablaResultados;

                    // 5. Ajustar columnas y el fondo
                    dgvResultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dgvResultados.BackgroundColor = System.Drawing.Color.White;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
