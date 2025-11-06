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
    public partial class FormFedericoNavarrete : Form
    {
        public FormFedericoNavarrete()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int anio = dtpPeliculas.Value.Year;
                int anioActual = DateTime.Now.Year;

                if (anio > anioActual)
                {
                    MessageBox.Show("No se puede consultar un año futuro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!rbtTop1.Checked && !rbtTop5.Checked)
                {
                    MessageBox.Show("Debe seleccionar un filtro: Top 1 o Top 5.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreSP = rbtTop1.Checked ? "PeliculaMasVendida" : "PeliculasTopRecaudacion";

                List<SqlParameter> parametros = new List<SqlParameter>
        {
            new SqlParameter("@anio", anio)
        };

                DataTable dt = GestorBD.EjecutarSP(nombreSP, parametros);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay resultados para el año seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPeliculas.DataSource = null;
                    return;
                }

                dgvPeliculas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
