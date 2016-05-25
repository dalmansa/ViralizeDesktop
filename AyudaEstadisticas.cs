using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViralizeDesktop
{
    public partial class AyudaEstadisticas : Form
    {
        public AyudaEstadisticas()
        {
            InitializeComponent();
        }

        private void AyudaEstadisticas_Load(object sender, EventArgs e)
        {
            label1.Text = ("Aquí puedes ver la cantidad de shares de"
                + "\n" + "cada reto que haya sido creado entre las fechas"
                + "\n" + "seleccionadas.");

            label2.Text = ("Fecha de inicio y final de los"
                + "\n" + "shares por reto.");

            label3.Text = ("Si haces clic en este botón actualizarás la"
                + "\n" + "gráfica de shares por reto con la información seleccionada."
                + "\n" + "");

            label4.Text = ("Aquí puedes ver la cantidad de shares que"
                + "\n" + "se han creado cada día las fechas"
                + "\n" + "seleccionadas.");

            label5.Text = ("Fecha de inicio y final de los"
                + "\n" + "shares por día.");

            label6.Text = ("Muestra todos los shares subidos entre las"
                + "\n" + "fechas indicadas haciendo clic en este botón.");

            label7.Text = ("En esta lista puedes ver todos los retos."
                + "\n" + "Selecciona uno haciendo clic en el.");

            label8.Text = ("Para ver los shares por día del reto"
                + "\n" + "seleccionado, haz clic en este botón.");

            label9.Text = ("Si deseas cerrar sesión y salir del programa"
                + "\n" + "haz clic en este botón.");
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
