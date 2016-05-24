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
using NReco.VideoConverter;

namespace ViralizeDesktop
{




    public partial class Propuestas : Form
    {

        private String logged;
        String userName;

        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        string getVideoUrl = "";
        int id=0;

        String errorBlancos;

        String titulo;
        String descripcion;
        DateTime fechaPublicacion;
        String urlVideo;
        int usuarioId;
        string hashkey = "ViralizeHashKey";

        public string Logged
        {
            get
            {
                return logged;
            }

            set
            {
                logged = value;
            }
        }

        public Propuestas()
        {
            InitializeComponent();
        }

        public Propuestas(string userName)
        {
            this.userName = userName;
        }

        private void Propuestas_Load(object sender, EventArgs e)
        {
            label6.Text = "Contraseña:";
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
           
            txtLogged.Text = logged;
            
            // TODO: This line of code loads data into the 'vIRALIZEDataSet.PROPUESTA_RETO' table. You can move, or remove it, as needed.
            this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);

            axWindowsMediaPlayer1.URL = @"";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            panelRegistro.Hide();
            panelAdmin.Hide();
        }

        private void CargarVideo(String videoUrl)
        {
            axWindowsMediaPlayer1.URL = @"" + getVideoUrl;
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
                //MessageBox.Show(getVideoUrl);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aProp_Click(object sender, EventArgs e)
        {


            if (id != 0)
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
                reto.fechaPublicacion = DateTime.Now.Date;
                reto.urlVideo = urlVideo;
                reto.usuarioID = usuarioId;
                reto.activo = 1;
                reto.plataformaID = 1;

                reto.fechaCaducidad = DateTime.Now.AddDays(31);

                dataContext.RETOes.Add(reto);
                dataContext.SaveChanges();
                MessageBox.Show("Accepted");
                this.pROPUESTA_RETOTableAdapter.Update(this.vIRALIZEDataSet.PROPUESTA_RETO);
                this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);
                //var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                //ffMpeg.GetVideoThumbnail(urlVideo, "C:\\Users\\Daniel\\Pictures\\imagenEEE.jpg", 1);


                //System.Net.WebClient Client = new System.Net.WebClient();

                //Client.Headers.Add("Content-Type", "binary/octet-stream");

                //byte[] result = Client.UploadFile("http://vreality.es/upload.php", "POST",
                //                                  @"C:\\Users\\Daniel\\Pictures\\imagenEE.jpg");

                //string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);

                rProp.PerformClick();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una propuesta a aceptar previamente.");
            }

        }

        private void rProp_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                var query = from al in dataContext.PROPUESTA_RETO
                            where al.id == id
                            select al;
                foreach (var al in query)
                {
                    dataContext.PROPUESTA_RETO.Remove(al);

                }
                dataContext.SaveChanges();

                this.pROPUESTA_RETOTableAdapter.Update(this.vIRALIZEDataSet.PROPUESTA_RETO);
                this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);



                MessageBox.Show("Propuesta eliminada");
            }
            else
            {
                MessageBox.Show("Debes seleccionar una propuesta a eliminar previamente.");
            }
        }

        private void propuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRegistro.Hide();
            panelPropuestas.Show();
            panelAdmin.Hide();

        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPropuestas.Hide();
            panelRegistro.Show();
            panelAdmin.Hide();
            panelPropuestas.Hide();
        }

        private void crearUsuarioButton_Click(object sender, EventArgs e)
        {
            
            if (comprobarExistencia() == false && comprobarBlancos() == false)
            {
                USUARIO user = new USUARIO();

                user.nombre = txtNombre.Text;
                user.apellidos = txtApellidos.Text;
                user.username = txtUsuario.Text;

                string hash = CreateSHAHash(txtPassword.Text, hashkey);
                user.passw = hash;

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
                else
                {
                    user.superusuario = 0;
                }

                user.plataformaID = 1;

                dataContext.USUARIOs.Add(user);
                dataContext.SaveChanges();
                MessageBox.Show("Usuario creado");
                //MessageBox.Show(hash);
            }

            if (comprobarExistencia()) {
                MessageBox.Show("El usuario ya existe");
            }

            if (comprobarBlancos()) {
                MessageBox.Show(errorBlancos);
            }


        }

        private Boolean comprobarBlancos() {
            Boolean esBlanco = false;
            if (txtNombre.Text == "")
            {
                esBlanco = true;
                errorBlancos = "Introduce nombre.";
            }
            else if (txtApellidos.Text == "")
            {
                esBlanco = true;
                errorBlancos = "Introduce apellido.";
            }
            else if (txtUsuario.Text == "")
            {
                esBlanco = true;
                errorBlancos = "Introduce usuario";
            }
            else if (txtPassword.Text == "")
            {
                esBlanco = true;
                errorBlancos = "Introduce contraseña";
            }
            else {
                esBlanco = false;
            }
            return esBlanco;
        }

        private Boolean comprobarExistencia()
        {
            Boolean existe = false;

            var query = from al in dataContext.USUARIOs
                        select al;
            foreach (var al in query)
            {
                if (al.username == txtUsuario.Text && al.id != id)
                {
                    existe = true;
                    break;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdmin.Show();
            panelPropuestas.Hide();
            panelRegistro.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gestionUsuarios gest = new gestionUsuarios();
            gest.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gestionRetos gRetos = new gestionRetos();
            gRetos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estadisticas est = new Estadisticas();
            est.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
