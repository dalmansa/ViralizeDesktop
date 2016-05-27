using System;
using System.Collections;
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
        //Conexión que utilizamos para consultar la base de datos
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        //Variables de control
        int activo;
        int id;
        int usuarioID;
        public gestionRetos()
        {
            InitializeComponent();
        }

        private void gestionRetos_Load(object sender, EventArgs e)
        {
            //Coloreamos el datagridview
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
            // TODO: This line of code loads data into the 'vIRALIZEDataSet2.RETO' table. You can move, or remove it, as needed.
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet2.RETO);
            //Evitamos que se pueda seleccionar mas de un campo en el datagridview
            //Si haces clic en un campo se selecciona la fila completa
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        //Metodo de comprobación de espacios en blanco en los campos
        //Si uno de los campos está en blanco, devolverá un "esblanco=true"
        private Boolean comprobarBlancos()
        {
            Boolean esBlanco = false;
            if (txtTitulo.Text == "")
            {
                esBlanco = true;
                MessageBox.Show("Título no puede estar en blanco.");
            }
            else if (txtDescripcion.Text == "")
            {
                esBlanco = true;
                MessageBox.Show("Descripción no puede estar en blanco.");
            }
            else if (txtURLVideo.Text == "")
            {
                esBlanco = true;
                MessageBox.Show("URL Video no puede estar en blanco.");
            }else if (dateTimeFinal.Value < dateTimeInicio.Value)
            {
                esBlanco = true;
                MessageBox.Show("La fecha de finalización no puede ser anterior a la de inicio.");
            }
            else {
                esBlanco = false;
            }
            return esBlanco;
        }


        //Método para actualizar datos del reto
        private void button2_Click(object sender, EventArgs e)
        {
            //Si hay algún reto seleccionado
            if (id != 0)
            {
                //Comprobamos que todos los campos estén rellenados
                if (comprobarBlancos() == false)
                {
                    //También comprobamos que la fecha de inicio del reto sea menor a la fecha de finalización
                    if (dateTimeInicio.Value < dateTimeFinal.Value)
                    {
                        //Si la fecha de finalización es anterior a hoy, desactivamos el reto
                        if (dateTimeFinal.Value < DateTime.Now)
                        {
                            checkActivo.Checked = false;
                            MessageBox.Show("El reto se ha desactivado");
                        }
                        //Query para actualizar el reto
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
                    else {
                        MessageBox.Show("La fecha final no puede ser anterior a la de inicio.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún reto.");
            }


           
        }
        //Método que rellena los campos del window cada vez que seleccionamos un reto en la lista del datagridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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


                //Si ese reto está activo, se marca la casilla
                if (activo == 1)
                {
                    checkActivo.Checked = true;
                }
                else
                {
                    checkActivo.Checked = false;
                }
                //Query para comprobar que usuarios han participado en un share
                bool paDentro = true;
                var query = from al in dataContext.SHAREs
                            where al.retoID == id
                            select al;
                ArrayList ar = new ArrayList();
                foreach (var al in query)
                {
                    foreach (SHARE a2l in ar)
                    {
                        //Si el usuario ha hecho mas de un share en ese reto, no se vuelve a mostrar
                        if ((al.id != a2l.id) && (a2l.usuarioID == al.usuarioID))
                        {
                            paDentro = false;
                        }
                    }
                    if (paDentro)
                    {
                        ar.Add(al);
                    }
                    // dataGridView2.Rows.Add(al.USUARIO.username);
                    //MessageBox.Show(al.USUARIO.username);

                }
                //Por cada usuario que participe en el reto, se añade a la lista
                foreach (SHARE ac in ar)
                {
                    listView1.Items.Add(ac.USUARIO.username);
                }




            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Evento del botón "Cerrar sesión" (se cierra la aplicación)
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento del botón "Atrás" (volvemos a la pantalla anterior)
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Abre el menú de ayuda de esta ventana en concreto
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaGRetos aGRetos = new AyudaGRetos();
            aGRetos.ShowDialog();
        }
        //Muestra un pequeño mensaje con la información del programa y los creadores de la aplicación
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viralize Desktop v1.01 26/05/2016" + "\n"
                + "\n" + "\n"
                + "Hecho por : Daniel Almansa, Jairo Pastor, Raúl Jurado y Sergio Sánchez"
                + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.rETOTableAdapter.Update(this.vIRALIZEDataSet2.RETO);
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet2.RETO);
        }
    }
}
