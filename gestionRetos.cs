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
    public partial class gestionRetos : Form
    {
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        int activo;
        int id;
        public gestionRetos()
        {
            InitializeComponent();
        }

        private void gestionRetos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIRALIZEDataSet2.RETO' table. You can move, or remove it, as needed.
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet2.RETO);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = from al in dataContext.RETOes
                        where al.id == id
                        select al;
            foreach (var al in query)
            {
                al.titulo = txtTitulo.Text;
                al.descripcion = txtDescripcion.Text;
                al.fechaPublicacion = dateTimeInicio.Value;
                al.fechaCaducidad = dateTimeFinal.Value;
                al.urlVideo = txtURLVideo.Text;

                if (checkActivo.Checked)
                {
                    al.activo = 1;
                }
                else
                {

                    al.activo = 0;
                }

                

            }
            dataContext.SaveChanges();

            this.rETOTableAdapter.Update(this.vIRALIZEDataSet2.RETO);
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet2.RETO);
           
            MessageBox.Show("Reto modificado");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                txtTitulo.Text = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                txtDescripcion.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                dateTimeInicio.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
                dateTimeFinal.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value);
                txtURLVideo.Text = (string)dataGridView1.SelectedRows[0].Cells[5].Value;
                activo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                


                if (activo == 1)
                {
                    checkActivo.Checked = true;
                }
                else
                {
                    checkActivo.Checked = false;
                }

                
            }



        }
    }
}
