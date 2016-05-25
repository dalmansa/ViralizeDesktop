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
    public partial class AyudaGUsuarios : Form
    {
        public AyudaGUsuarios()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AyudaGUsuarios_Load(object sender, EventArgs e)
        {
            label1.Text = ("Aquí puedes ver los usuarios registrados"
                + "\n" + "en Viralize."
                + "\n" + "Haz clic sobre uno para seleccionarlo.");
            

            label3.Text = ("En estos campos puedes editar la información"
                + "\n" + "del usuario que esté seleccionado."
                + "\n" + "");

            label4.Text = ("Si haces clic en este botón actualizarás"
                + "\n" + "un usuario a partir de la información introducida."
                + "\n" + "Debes elegir un usuario previamente para actualizarlo.");

            label5.Text = ("Si deseas cerrar sesión y salir del programa"
                + "\n" + "haz clic en este botón.");
        }
    }
}
