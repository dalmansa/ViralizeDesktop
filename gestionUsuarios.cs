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
    public partial class gestionUsuarios : Form
    {
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        int id;
        int admin;
        int super;
        string hashkey = "ViralizeHashKey";
        public gestionUsuarios()
        {
            InitializeComponent();
        }

        private void gestionUsuarios_Load(object sender, EventArgs e)
        {
            //Le cambiamos los colores al datagridview
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
            // TODO: This line of code loads data into the 'vIRALIZEDataSetUSUARIOS.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter1.Fill(this.vIRALIZEDataSetUSUARIOS.USUARIO);
            // TODO: This line of code loads data into the 'vIRALIZEDataSet1.USUARIO' table. You can move, or remove it, as needed.
            //this.uSUARIOTableAdapter.Fill(this.vIRALIZEDataSet1.USUARIO);
            //Evitamos que se pueda seleccionar mas de un campo en el datagridview
            //Y si seleccionas un campo, se selecciona la linea completa
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }
        //Evento del botón "borrar usuario", que al final no utilizamos en el programa
        private void button1_Click(object sender, EventArgs e)
        {

            var query = from al in dataContext.USUARIOs
                        where al.id == id
                        select al;
            foreach (var al in query)
            {
                dataContext.USUARIOs.Remove(al);

            }
            dataContext.SaveChanges();

            this.uSUARIOTableAdapter1.Update(this.vIRALIZEDataSetUSUARIOS.USUARIO);
            this.uSUARIOTableAdapter1.Fill(this.vIRALIZEDataSetUSUARIOS.USUARIO);
            MessageBox.Show("Usuario eliminado");

        }
        //Evento que controla donde se hace clic del datagridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                //Si haces clic en una linea del datagridview, rellena los campos
                //con los valores de la linea seleccionada
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                txtNombre.Text = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                txtApellidos.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                txtPassword.Text = (string)dataGridView1.SelectedRows[0].Cells[4].Value;
                txtUsername.Text = (string)dataGridView1.SelectedRows[0].Cells[3].Value;

                admin = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                super= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);

                //Si es admin, se marca la casilla
                if (admin == 1)
                {
                    checkAdmin.Checked = true;
                }
                else {
                    checkAdmin.Checked = false;
                }
                //Si es super usuario, se marca la casilla
                if (super == 1)
                {
                    checkSuper.Checked = true;
                }
                else
                {
                    checkSuper.Checked = false;
                }
            }

            

        }
        //Control de espacios en blanco
        //Si un espacio está sin rellenar (los que albergan texto) no permitirá hacer nada
        //hasta que se rellene
        private Boolean comprobarBlancos()
        {
            Boolean esBlanco = false;
            if (txtNombre.Text == "")
            {
                esBlanco = true;
                MessageBox.Show ("Nombre no puede estar en blanco.");
            }
            else if (txtApellidos.Text == "")
            {
                esBlanco = true;
                MessageBox.Show ("Apellido no puede estar en blanco.");
            }
            else if (txtUsername.Text == "")
            {
                esBlanco = true;
                MessageBox.Show ("Usuario no puede estar en blanco.");
            }
            else if (txtPassword.Text == "")
            {
                esBlanco = true;
                MessageBox.Show  ("Contraseña no puede estar en blanco.");
            }
            else {
                esBlanco = false;
            }
            return esBlanco;
        }

        //Evento del botón "Actualizar datos"
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Si hay un usuario seleccionado
            if (id != 0)
            {
                //Si el nuevo nombre de usuario es distinto a uno existente en la base de datos
                //y no hay ningún campo en blanco
                if (comprobarExistencia() == false && comprobarBlancos() == false)
                {
                    //Se actualiza el registro del usuario en la base de datos
                    var query = from al in dataContext.USUARIOs
                                where al.id == id
                                select al;
                    foreach (var al in query)
                    {
                        al.nombre = txtNombre.Text;
                        al.apellidos = txtApellidos.Text;
                        al.username = txtUsername.Text;
                        //Si detecta que la contraseña es distinta de la que tiene en la base de datos, la actualiza
                        if (txtPassword.Text != dataGridView1.SelectedRows[0].Cells[4].Value.ToString())
                        {
                            MessageBox.Show("La contraseña es distinta. Se va a actualizar.");
                            //Crea hash de la nueva contraseña y la guarda
                            string hash = CreateSHAHash(txtPassword.Text, hashkey);
                            al.passw = hash;
                        }
                        //Si admin está marcado...
                        if (checkAdmin.Checked)
                        {
                            al.administrador = 1;
                        }
                        else
                        {

                            al.administrador = 0;
                        }
                        //Si superusuario está marcado...
                        if (checkSuper.Checked)
                        {
                            al.superusuario = 1;
                        }
                        else
                        {
                            al.superusuario = 0;
                        }

                    }
                    //Se guardan los cambios en la base de datos
                    dataContext.SaveChanges();
                    //Se vuelve a cargar todo en el datagridview , mostrando la nueva información
                    this.uSUARIOTableAdapter1.Update(this.vIRALIZEDataSetUSUARIOS.USUARIO);
                    this.uSUARIOTableAdapter1.Fill(this.vIRALIZEDataSetUSUARIOS.USUARIO);


                    MessageBox.Show("Usuario modificado.");
                }
                else {
                    //Muestra este error si el nuevo username ya está siendo utilizado por otro usuario
                    if (comprobarExistencia() == true)
                    {
                        MessageBox.Show("Usuario ya existe.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún usuario.");
            }

            
        }

        //Método para comprobar si el nombre de usuario ya existe
        //Si este existe, se devuelve un true.
        private  Boolean comprobarExistencia() {
            Boolean existe = false;

            var query = from al in dataContext.USUARIOs 
                        select al;
            foreach (var al in query)
            {
                if (al.username == txtUsername.Text && al.id != id)
                {
                    existe = true;
                    break;
                }
                else {
                    existe = false;
                }
            }
            return existe;
            }

        //Método para encriptar la contraseña
        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }
        //Evento del botón "Cerrar sesión" (cierra la aplicación)
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento del botón "Atrás" (vuelve a la ventana anterior)
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evento del botón "Ayuda" (muestra la ayuda correspondiente a esta ventana)
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaGUsuarios aUsers = new AyudaGUsuarios();
            aUsers.ShowDialog();
        }
        //Evento del botón "Acerca de..." (muestra información sobre el programa y sus creadores)
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viralize Desktop v1.01 26/05/2016" + "\n"
                + "\n" + "\n"
                + "Hecho por : Daniel Almansa, Jairo Pastor, Raúl Jurado y Sergio Sánchez"
                + "\n");
        }
    }
}
