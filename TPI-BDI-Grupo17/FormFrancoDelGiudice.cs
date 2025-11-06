using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_BDI_Grupo17
{
    public partial class FormFrancoDelGiudice : Form
    {
        public FormFrancoDelGiudice()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = GestorBD.GetPeoresDias(dtpDesde.Value, dtpHasta.Value);
                gridResultados.DataSource = dt; // el grid está dentro del groupbox, no importa
                gridResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta:\n" + ex.Message,
                                "BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
