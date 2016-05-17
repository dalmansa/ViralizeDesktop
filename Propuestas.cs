using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Necesario para hash SHA512 */
using System.Security.Cryptography;
using System.Text;

namespace ViralizeDesktop
{




    public partial class Propuestas : Form
    {
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        string getVideoUrl = "";
        int id;

        String titulo;
        String descripcion;
        DateTime fechaPublicacion;
        String urlVideo;
        int usuarioId;
        string hashkey = "ViralizeHashKey";

        public Propuestas()
        {
            InitializeComponent();
        }

        private void Propuestas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIRALIZEDataSet.PROPUESTA_RETO' table. You can move, or remove it, as needed.
            this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);

            axWindowsMediaPlayer1.URL = @"";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            panelRegistro.Hide();
        }

        private void CargarVideo(String videoUrl)
        {
            axWindowsMediaPlayer1.URL = @"http://" + getVideoUrl;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://vreality.es/dani.mp4";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //GridViewRow row = dataGridView1.SelectedRows;
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                getVideoUrl = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                CargarVideo(getVideoUrl);
                MessageBox.Show(getVideoUrl);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aProp_Click(object sender, EventArgs e)
        {
            var query =
                from al in dataContext.PROPUESTA_RETO
                where al.id == id
                select al;

            foreach (var al in query)
            {
                titulo = al.titulo;
                descripcion = al.descripcion;
                fechaPublicacion = al.fechaPublicacion;
                urlVideo = al.urlVideo;
                usuarioId = al.usuarioID;

            }


            RETO reto = new RETO();

            reto.titulo = titulo;
            reto.descripcion = descripcion;
            reto.fechaPublicacion = fechaPublicacion;
            reto.urlVideo = urlVideo;
            reto.usuarioID = usuarioId;
            reto.activo = 1;
            reto.plataformaID = 1;

            reto.fechaCaducidad = DateTime.Now.AddDays(31);

            dataContext.RETOes.Add(reto);
            dataContext.SaveChanges();
            MessageBox.Show("Accepted");

        }

        private void rProp_Click(object sender, EventArgs e)
        {
            var query = from al in dataContext.PROPUESTA_RETO
                        where al.id == id
                        select al;
            foreach (var al in query)
            {
                dataContext.PROPUESTA_RETO.Remove(al);

            }
            dataContext.SaveChanges();


            MessageBox.Show("Denied");
        }

        private void propuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegistro.Hide();
            panelPropuestas.Show();
        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPropuestas.Hide();
            panelRegistro.Show();
        }

        private void crearUsuarioButton_Click(object sender, EventArgs e)
        {
            USUARIO user = new USUARIO();

            user.nombre = txtNombre.Text;
            user.apellidos = txtApellidos.Text;
            user.username = txtUsuario.Text;

            string hash = CreateSHAHash(txtPassword.Text, hashkey);
            user.password = hash;

            if (checkAdmin.Checked)
            {
                user.administrador = 1;
            }
            else
            {
                user.administrador = 0;
            }

            if (checkSuper.Checked)
            {
                user.superusuario = 1;
            }
            else {
                user.superusuario = 0;
            }

            user.plataformaID = 1;

            dataContext.USUARIOs.Add(user);
            dataContext.SaveChanges();
            MessageBox.Show("Usuario creado");
            MessageBox.Show(hash);


        }

        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }
    } 
}
