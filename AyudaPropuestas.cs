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
    public partial class AyudaPropuestas : Form
    {
        public AyudaPropuestas()
        {
            InitializeComponent();
        }

        private void AyudaPropuestas_Load(object sender, EventArgs e)
        {
            label1.Text=("Aquí puedes ver los retos propuestos por" 
                + "\n" + "los usuarios de Viralize." 
                +"\n" +"Haz clic sobre uno para seleccionarlo.");

            label2.Text = ("En este reproductor podrás visualizar"
                + "\n" + "el video de la propuesta seleccionada."
                + "\n" + "");

            label3.Text = ("Si haces clic en este botón rechazarás"
                + "\n" + "la propuesta que esté seleccionada."
                + "\n" + "");

            label4.Text = ("Si haces clic en este botón crearás"
                + "\n" + "un reto a partir de la propuesta seleccionada."
                + "\n" + "Después de esto desaparecerá de la lista.");

            label5.Text = ("Si deseas cerrar sesión y salir del programa"
                + "\n" + "haz clic en este botón.");
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
