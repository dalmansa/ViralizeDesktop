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
using System.Net;
using System.IO;

namespace ViralizeDesktop
{




    public partial class Propuestas : Form
    {

        private String logged;
        String userName;
        //Conexión que utilizaremos para trabajar con la base de datos
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        string getVideoUrl = "";
        int id=0;
        //Variables de control
        String errorBlancos;
        String titulo;
        String descripcion;
        DateTime fechaPublicacion;
        String urlVideo;
        int usuarioId;
        //Clave única de la cual generará el hash
        string hashkey = "ViralizeHashKey";
        //int de control para la pantalla de ayuda
        int pantAyuda = 1;

        //Método para poder recibir los datos del usuario desde el form de inicio de sesión
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
        //Constructor en el que se recibe el nombre del usuario (en desuso)
        public Propuestas(string userName)
        {
            this.userName = userName;
        }

        private void Propuestas_Load(object sender, EventArgs e)
        {
            //Cambio de valor en label y cambio de color del datagridview
            label6.Text = "Contraseña:";
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
           
            txtLogged.Text = logged;
            
            // TODO: This line of code loads data into the 'vIRALIZEDataSet.PROPUESTA_RETO' table. You can move, or remove it, as needed.
            this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);

            axWindowsMediaPlayer1.URL = @"";
            //Limitación del datagridview para que solo se pueda seleccionar una linea a la vez
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            //Escondemos los otros paneles
            panelRegistro.Hide();
            panelAdmin.Hide();
        }
        //Método que carga el video en el previsualizador de video
        private void CargarVideo(String videoUrl)
        {
            axWindowsMediaPlayer1.URL = @"" + getVideoUrl;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Control de selección de datos del datagridview de "propuestas"
        //Al hacer clic sobre una propuesta, llama a "cargarvideo" y reproduce 
        //el video de la URL de la propuesta
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

        //Método que genera un nombre aleatorio que usaremos en el momento de subir 
        //la vista previa del video al servidor
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Evento del botón de "Aceptar propuesta"
        private void aProp_Click(object sender, EventArgs e)
        {
            if (id != 0) {
                    //-------------------------------------------------------------------------------------------------------
                    //Generamos el nombre del archivo llamando al método y añadimos la extensión .jpg
                    string nombreImangen = RandomString(6) + ".jpg";
                    //Generamos el thumbnail en el directorio actual
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffMpeg.GetVideoThumbnail(getVideoUrl, "..\\" + nombreImangen, 1);


                    //Subimos el thumbnail
                    //string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
                    String sourcefilepath = "..\\" + nombreImangen; // e.g. “d:/test.docx”
                                                                    //String sourcefilepath = "C:\\Users\\Daniel\\Pictures\\" + nombreImangen; // e.g. “d:/test.docx”
                                                                    //Introducimos URL de ftp y el nombre de la imagen, identificador, contraseña...
                    String ftpurl = "ftp://31.220.16.148/viralfotos/" + nombreImangen; // e.g. ftp://serverip/foldername/foldername
                    String ftpusername = "u393771917"; // e.g. username
                    String ftppassword = "viralize"; // e.g. password
                                                     //Proceso de subida del archivo
                    try
                    {
                        string filename = Path.GetFileName(sourcefilepath);
                        string ftpfullpath = ftpurl;
                        FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                        ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);

                        ftp.KeepAlive = true;
                        ftp.UseBinary = true;
                        ftp.Method = WebRequestMethods.Ftp.UploadFile;

                        FileStream fs = File.OpenRead(sourcefilepath);
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();

                        Stream ftpstream = ftp.GetRequestStream();
                        ftpstream.Write(buffer, 0, buffer.Length);
                        ftpstream.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    //Eliminamos la imagen del disco local ya que no la volveremos a necesitar aqui
                    System.IO.File.Delete("..\\" + nombreImangen);
                    //-------------------------------------------------------------------------------------------------------

                    //Si la ID es diferente de 0 (si hay una propuesta seleccionada), esta se guarda en la base de datos
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
                        reto.urlThumbnail = "http://vreality.es/viralfotos/" + nombreImangen;
                        reto.fechaCaducidad = DateTime.Now.AddDays(31);

                        dataContext.RETOes.Add(reto);
                        //Se guardan los cambios en la base de datos
                        dataContext.SaveChanges();
                        MessageBox.Show("Propuesta aceptada.");
                        //Se rellena los campos del datagridview con la información actual
                        this.pROPUESTA_RETOTableAdapter.Update(this.vIRALIZEDataSet.PROPUESTA_RETO);
                        this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);




                        //Y borramos la propuesta
                        rProp.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Debes seleccionar una propuesta a aceptar previamente.");
                    } }
            else
            {
                MessageBox.Show("Debes seleccionar una propuesta a aceptar previamente.");
            }

        }
        //Evento del botón de denegar propuesta
        private void rProp_Click(object sender, EventArgs e)
        {
            //Si la propuesta seleccionada no tiene ID 0, se borra
            if (id != 0)
            {
                var query = from al in dataContext.PROPUESTA_RETO
                            where al.id == id
                            select al;
                foreach (var al in query)
                {
                    dataContext.PROPUESTA_RETO.Remove(al);

                }
                //Guardamos cambios
                dataContext.SaveChanges();
                //Actualizamos el datagridview con los cambios
                this.pROPUESTA_RETOTableAdapter.Update(this.vIRALIZEDataSet.PROPUESTA_RETO);
                this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);



                MessageBox.Show("Propuesta eliminada");
            }
            else
            {
                MessageBox.Show("Debes seleccionar una propuesta a eliminar previamente.");
            }
        }
        //Evento del click de la pestaña "Propuestas"
        private void propuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Escondemos todos los paneles y solo mostramos el de respuestas
            //pantAyuda = 1;
            panelRegistro.Hide();
            panelPropuestas.Show();
            panelAdmin.Hide();

        }
        //Evento del click de la pestaña "Crear usuario"
        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Escondemos todos los paneles y solo mostramos el de crear usuario
            panelPropuestas.Hide();
            panelRegistro.Show();
            panelAdmin.Hide();
            panelPropuestas.Hide();
        }
        //Evento del botón "crear usuario" en el panel "Usuario"
        private void crearUsuarioButton_Click(object sender, EventArgs e)
        {
            //Se comprueba que no exista el nombre de usuario en la base de datos
            if (comprobarExistencia())
            {
                MessageBox.Show("El usuario ya existe");
            }

            //Se comprueba que no haya un campo vacio
            if (comprobarBlancos())
            {
                MessageBox.Show(errorBlancos);
            }
            //Si el nombre de usuario no existe y los campos están rellenados, se procede a crear un nuevo usuario
            if (comprobarExistencia() == false && comprobarBlancos() == false)
            {
                USUARIO user = new USUARIO();
                //Se guardan la información de los campos en el nuevo usuario
                user.nombre = txtNombre.Text;
                user.apellidos = txtApellidos.Text;
                user.username = txtUsuario.Text;
                //Se encripta la contraseña
                string hash = CreateSHAHash(txtPassword.Text, hashkey);
                user.passw = hash;
                //Se comprueba los campos de admin/superusuario a rellenar
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
                //Y se pone el tipo de paltaforma que es (sólo es posible la número 1 por ahora)
                user.plataformaID = 1;
                //Se añade el usuario
                dataContext.USUARIOs.Add(user);
                //Se guardan los cambios
                dataContext.SaveChanges();
                MessageBox.Show("Usuario creado");
            }

            

            


        }
        //Comprobación de blancos, si hay blancos, no permite guardar el usuario
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
        //Se comprueba que no existe previamente el usuario en la base de datos
        private Boolean comprobarExistencia()
        {
            Boolean existe = false;
            //Consulta los nombres de usuario, si el que hemos escrito existe, no permite avanzar
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
        //Se crea un hash a partir de la semilla de hash introducida previamente
        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }
        //Si se hace clic en la pestaña administración, solo se muestra la pestaña de Administración
        //y se esconden las demás
        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdmin.Show();
            panelPropuestas.Hide();
            panelRegistro.Hide();
        }
        //Se abre una nueva ventana de gestión de usuarios
        private void button1_Click_1(object sender, EventArgs e)
        {
            gestionUsuarios gest = new gestionUsuarios();
            gest.ShowDialog();
        }
        //Se abre una nueva ventana de gestión de retos
        private void button2_Click_1(object sender, EventArgs e)
        {
            gestionRetos gRetos = new gestionRetos();
            gRetos.ShowDialog();
        }
        //Se abre una nueva ventana de estadísticas
        private void button3_Click(object sender, EventArgs e)
        {
            Estadisticas est = new Estadisticas();
            est.ShowDialog();
        }
        //Evento del botón de "Cerrar sesión" (se cierra el programa entero)
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento del botón de "Atrás" (te devuelve a la pantalla anterior)
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //Evento del botón "Acerca de..." que muestra la versión del programa e información
        //de los creadores de este
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viralize Desktop v1.01 26/05/2016" + "\n"
                + "\n" + "\n"
                + "Hecho por : Daniel Almansa, Jairo Pastor, Raúl Jurado y Sergio Sánchez"
                + "\n");
        }
        //Evento del botón "Ayuda" que muestra la ventana de ayuda correspondiente a esta pantalla
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pantAyuda == 1)
            {
                AyudaPropuestas aProp = new AyudaPropuestas();
                aProp.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pROPUESTA_RETOTableAdapter.Update(this.vIRALIZEDataSet.PROPUESTA_RETO);
            this.pROPUESTA_RETOTableAdapter.Fill(this.vIRALIZEDataSet.PROPUESTA_RETO);
        }
    } 
}
