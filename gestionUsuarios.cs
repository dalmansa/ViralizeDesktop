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
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
            // TODO: This line of code loads data into the 'vIRALIZEDataSetUSUARIOS.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter1.Fill(this.vIRALIZEDataSetUSUARIOS.USUARIO);
            // TODO: This line of code loads data into the 'vIRALIZEDataSet1.USUARIO' table. You can move, or remove it, as needed.
            //this.uSUARIOTableAdapter.Fill(this.vIRALIZEDataSet1.USUARIO);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                txtNombre.Text = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                txtApellidos.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                txtPassword.Text = (string)dataGridView1.SelectedRows[0].Cells[4].Value;
                txtUsername.Text = (string)dataGridView1.SelectedRows[0].Cells[3].Value;

                admin = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                super= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);


                if (admin == 1)
                {
                    checkAdmin.Checked = true;
                }
                else {
                    checkAdmin.Checked = false;
                }

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


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (comprobarExistencia() == false && comprobarBlancos() == false)
                {
                    var query = from al in dataContext.USUARIOs
                                where al.id == id
                                select al;
                    foreach (var al in query)
                    {
                        al.nombre = txtNombre.Text;
                        al.apellidos = txtApellidos.Text;
                        al.username = txtUsername.Text;

                        if (txtPassword.Text != dataGridView1.SelectedRows[0].Cells[4].Value.ToString())
                        {
                            MessageBox.Show("La contraseña es distinta. Se va a actualizar.");
                            string hash = CreateSHAHash(txtPassword.Text, hashkey);
                            al.passw = hash;
                        }

                        if (checkAdmin.Checked)
                        {
                            al.administrador = 1;
                        }
                        else
                        {

                            al.administrador = 0;
                        }

                        if (checkSuper.Checked)
                        {
                            al.superusuario = 1;
                        }
                        else
                        {
                            al.superusuario = 0;
                        }

                    }
                    dataContext.SaveChanges();

                    this.uSUARIOTableAdapter1.Update(this.vIRALIZEDataSetUSUARIOS.USUARIO);
                    this.uSUARIOTableAdapter1.Fill(this.vIRALIZEDataSetUSUARIOS.USUARIO);


                    MessageBox.Show("Usuario modificado.");
                }
                else {
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

        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
