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
        }

        private void CargarVideo(String videoUrl)
        {
            axWindowsMediaPlayer1.URL = @"http://"+getVideoUrl;
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
            reto.fechaCaducidad = DateTime.Now;

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
    }
}
