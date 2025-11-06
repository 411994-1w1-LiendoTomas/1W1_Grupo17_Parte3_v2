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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoUno_Click(object sender, EventArgs e)
        {
            // Abrir un formulario con la información de la Consulta 1

            MessageBox.Show("Esta consulta muestra los 3 días con menor recaudación y los 3 días con menor cantidad de entradas vendidas en el último mes. Además, en cada caso se indica cuál fue la película más vista durante esos días. Sirve para identificar cuáles fueron los días más flojos en términos de ventas y asistencia, y entender qué contenido se estaba ofreciendo.", "412427, Franco del Giudice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoDos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta que genera un reporte con las 5 combinaciones de género, clasificación, día de la semana y horario que más entradas han vendido en los últimos 3 meses. Se excluye el día de la semana que más entradas haya vendido. Se incluye el número total de entradas vendidas y la recaudación para cada combinación. Ordenado de mayor a menor según cantidad de entradas vendidas. El objetivo es descubrir las combinaciones de películas y horarios más rentables en los días de menor venta, que permitan buscar oportunidades de negocio para optimizar la programación y aumentar los ingresos.", "411994, Tomás Agustín Liendo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private void infoTres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta que muestre las películas que más entradas vendieron, las cuales hayan superado en recaudación al promedio general de recaudación del año, mostrando cuánto recaudó cada película, ordenadas de forma descendente por cantidad de entradas vendidas. Todo en el año actual.", "412090, Federico Iván Navarrete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoCuatro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La consulta muestra la cantidad total de facturas, el monto total recaudado y la proporción sobre el total de facturas por el método de pago en el último trimestre. Sirve para evaluar la conveniencia de cada método de pago, preferencias a la hora de abonar y posibles oportunidades de promociones bancarias o descuentos digitales. ", "423238, Ignacio Tomás Rosso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ejecutarDos_Click(object sender, EventArgs e)
        {
            FormTomasLiendo formTomasLiendo = new FormTomasLiendo();
            formTomasLiendo.ShowDialog();
        }
    }
}
