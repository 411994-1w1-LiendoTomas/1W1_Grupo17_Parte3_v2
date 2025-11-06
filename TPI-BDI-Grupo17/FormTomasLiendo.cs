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
    public partial class FormTomasLiendo : Form
    {
        public FormTomasLiendo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTomasLiendo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value;
                DateTime fechaHasta = dtpFechaHasta.Value;
                DateTime hoy = DateTime.Now;

                // Validaciones de fecha:

                if (fechaDesde >= fechaHasta)
                {
                    MessageBox.Show("La fecha 'Desde' debe ser anterior a la fecha 'Hasta'.",
                                    "Error de validación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if((fechaHasta - fechaDesde).TotalDays < 7)
                {
                    MessageBox.Show("El rango entre las fechas debe ser al menos de 7 días.",
                                    "Error de validación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if(fechaHasta > hoy)
                {
                    MessageBox.Show("La fecha 'Hasta' no puede ser una fecha futura.",
                                    "Error de validación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Si todas las validaciones son correctas:

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@FechaDesde", fechaDesde));
                parametros.Add(new SqlParameter("@FechaHasta", fechaHasta));

                DataTable dt = GestorBD.EjecutarSP("SP_Consulta_Tomas_Liendo", parametros);

                dgvResultados.DataSource = dt;

                dgvResultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + 
                                ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
