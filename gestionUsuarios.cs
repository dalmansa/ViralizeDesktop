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
        public gestionUsuarios()
        {
            InitializeComponent();
        }

        private void gestionUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIRALIZEDataSet1.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.vIRALIZEDataSet1.USUARIO);
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

            this.uSUARIOTableAdapter.Update(this.vIRALIZEDataSet1.USUARIO);
            this.uSUARIOTableAdapter.Fill(this.vIRALIZEDataSet1.USUARIO);
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

                int admin = (int)dataGridView1.SelectedRows[0].Cells[7].Value;
                int super= (int)dataGridView1.SelectedRows[0].Cells[8].Value;


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


        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
