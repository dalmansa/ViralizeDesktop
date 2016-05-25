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
    public partial class AyudaGRetos : Form
    {
        public AyudaGRetos()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AyudaGRetos_Load(object sender, EventArgs e)
        {
            label1.Text = ("Aquí puedes ver los retos creados por"
                + "\n" + "los usuarios de Viralize."
                + "\n" + "Haz clic sobre uno para seleccionarlo.");

            label2.Text = ("En esta lista podrás visualizar los"
                + "\n" + "usuarios que han participado en el reto"
                + "\n" + "seleccionado.");

            label3.Text = ("En estos campos puedes editar la información"
                + "\n" + "del reto que esté seleccionado."
                + "\n" + "");

            label4.Text = ("Si haces clic en este botón actualizarás"
                + "\n" + "un reto a partir de la información introducida."
                + "\n" + "Debes elegir un reto previamente para actualizarlo.");

            label5.Text = ("Si deseas cerrar sesión y salir del programa"
                + "\n" + "haz clic en este botón.");
        }
    }
}
