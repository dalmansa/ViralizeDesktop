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
    public partial class Estadisticas : Form
    {
        //Campo ID para controlar la id de los datagridview
        int id;
        //Conexión a la base de datos que utilizaremos
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            //Estil visual del datagridview
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.GreenYellow;
            // TODO: This line of code loads data into the 'vIRALIZEDataSet3.RETO' table. You can move, or remove it, as needed.
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet3.RETO);
            cargarChar1();
            //Bloqueamos las funciones del datagridview (solo podremos seleccionar una fila a la vez)
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }
        //Método que muestra la cantidad de shares en un reto en una gráfica
        private void cargarChar1()
        {
            //Variables de control
            String nombreReto;
            //Count a cero para cada reto
            int countShares = 0;
            //Consulta que recoge los shares
            var groupJoinQuery =
                from retos in dataContext.RETOes
                join shares in dataContext.SHAREs on retos.id equals shares.retoID into sharesGrup
                select new
                {
                    Reto = retos.titulo,
                    Shars = from share2 in sharesGrup
                            select share2
                };
            //Por cada reto, añade una abrra al gráfico con el nombre de este y la cantidad de shares
            foreach (var sharesGrup in groupJoinQuery)
            {
                countShares = 0;
                nombreReto = sharesGrup.Reto;
                foreach (var shareItem in sharesGrup.Shars)
                {
                    countShares = countShares + 1;
                }

                chartShares.Series["Shares"].Points.AddXY(nombreReto, countShares);
            }
        }
        //Método que carga los shares del reto en concreto en una gráfica (shares por día)
        private void cargarChar2Concreto()
        {
            //Si la id del reto seleccionado es diferente a cero (eso significa que hay un reto seleccionado)
            if (id != 0)
            {
                //Variables de control
                Boolean esReto = false;
                DateTime inicio;
                DateTime final;
                int count = 0;
                String dt = "";
                //Introducimos los valores del calendario en cada variable
                inicio = fechaInicio.Value;
                final = fechaFin.Value;
                //Consulta que busca los shares
                var query = from fe in dataContext.SHAREs
                            orderby fe.fechaPublicacion
                            group fe by fe.fechaPublicacion into g
                            select g;
                //Por cada día, creamos un punto en el gráfico con el día y la cantidad de shares subidos
                foreach (IGrouping<DateTime, SHARE> studentGroup in query)
                {
                    count = 0;
                    esReto = false;
                    foreach (SHARE fe in studentGroup)
                    {
                        // esReto = (fe.retoID == id);
                        //Si la ID del reto de ese share es la misma del que tenemos seleccionado, lo utilizamos
                        if (fe.retoID == id)
                        {

                            if (Between(fe.fechaPublicacion, inicio, final))
                            {
                                esReto = true;
                                //MessageBox.Show(fe.fechaPublicacion.ToString());    
                                count++;
                                dt = fe.fechaPublicacion.ToShortDateString();
                            }
                        }
                    }
                    if (esReto)
                    {
                        //MessageBox.Show("ENTRA");
                        chartFechas.Series["Shares"].Points.AddXY(dt, count);
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecciona un reto de la lista.");
            }
        }
        //Método que carga los shares por día de todos los retos
        private void cargarChar2()
        {
            //Variables de control
            DateTime inicio;
            DateTime final;
            int count = 0;
            DateTime dt = new DateTime();
            //Introducimos los valores del calendario en cada variable
            inicio = fechaInicio.Value;
            final = fechaFin.Value;
            //Consulta que busca los shares
            var query = from fe in dataContext.SHAREs
                        orderby fe.fechaPublicacion
                        group fe by fe.fechaPublicacion into g
                        select g;
            //Por cada día, creamos un punto en el gráfico con el día y la cantidad de shares subidos
            foreach (IGrouping<DateTime, SHARE> studentGroup in query)
            {
                count = 0;
                foreach (SHARE fe in studentGroup)
                {
                    if (Between(fe.fechaPublicacion, inicio, final))
                    {
                        count = count + 1;
                        dt = fe.fechaPublicacion;

                    }
                }

                chartFechas.Series["Shares"].Points.AddXY(dt.ToShortDateString(), count);
            }
        }
        //Método que comprueba que estamos entre esas fechas
        public static bool Between(DateTime input, DateTime date1, DateTime date2)
        {
            return (input >= date1 && input <= date2);
        }


        //Evento del botón "Mostrar todos"
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Comprueba que la fecha de finalización es mayor a la de inicio
            if (fechaFin.Value > fechaInicio.Value)
            {
                //Vacia el contenido de la gráfica
                chartFechas.Series[0].Points.Clear();
                //Llama al método para cargar datos de todos los retos
                cargarChar2();
            }
            else
            {
                //Si la fecha de finalización es menor a la de inicio, muestra error
                MessageBox.Show("La fecha de finalización no puede ser anterior o igual a la de inicio.");
            }
            
        }
        //Evento del botón "Mostrar videos de share en concreto"
        private void button1_Click(object sender, EventArgs e)
        {
            //Comprueba que la fecha de finalización es mayor a la de inicio
            if (fechaFin.Value > fechaInicio.Value)
            {
                //Vacia el contenido de la gráfica
                chartFechas.Series[0].Points.Clear();
            //MessageBox.Show(id.ToString());
            //Llama al método para cargar datos de reto concreto
            cargarChar2Concreto();
            }
            else
            {
                //Si la fecha de finalización es menor a la de inicio, muestra error
                MessageBox.Show("La fecha de finalización no puede ser anterior o igual a la de inicio.");
            }
        }
        //Control de selección del datagridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                
            }

            //MessageBox.Show(id.ToString());
        }
        //Botón que hace la consulta de "Shares por reto"
        private void button2_Click(object sender, EventArgs e)
        {
            if (fechaFinal2.Value > fechaInicio2.Value)
            {
                //Vaciamos el contenido de la gráfica antes de introducirle nuevos datos
                chartShares.Series[0].Points.Clear();
                //Variables de control
                DateTime inicio;
                DateTime final;
                //Cargamos la fecha de los campos de día en las variables creadas arriba
                inicio = fechaInicio2.Value;
                final = fechaFinal2.Value;
                Boolean entreFechas = false;

                String nombreReto;
                //Inicializamos el contador de shares a 0
                int countShares = 0;
                //Consulta para coger la información de todos los shares
                var groupJoinQuery =
                    from retos in dataContext.RETOes
                    join shares in dataContext.SHAREs on retos.id equals shares.retoID into sharesGrup
                    select new
                    {
                        Reto = retos.titulo,
                        Shars = from share2 in sharesGrup
                                select share2
                    };
                //Por cada reto, contamos la cantidad de Shares que pertenecen a este
                foreach (var sharesGrup in groupJoinQuery)
                {
                    countShares = 0;
                    nombreReto = sharesGrup.Reto;
                    foreach (var shareItem in sharesGrup.Shars)
                    {
                        //Llama al método "Between" para comprobar que ese share esta en ese reto
                        if (Between(shareItem.RETO.fechaPublicacion, inicio, final))
                        {
                            countShares = countShares + 1;
                            entreFechas = true;
                        }
                        else {
                            entreFechas = false;
                        }

                    }
                    if (entreFechas)
                    {
                        //Creamos una "barra" en la gráfica con el nombre del Reto y la cantidad de Shares
                        chartShares.Series["Shares"].Points.AddXY(nombreReto, countShares);
                    }

                }
            }
            else
            {
                MessageBox.Show("La fecha de finalización no puede ser anterior a la de inicio.");
            }

        }
        //Evento del botón "cerrar sesión"
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento del botón "Atrás" (te lleva a la ventana anterior)
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo que muestra una pequeña descripción de los creadores
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viralize Desktop v1.01 26/05/2016" + "\n"
                + "\n" + "\n"
                + "Hecho por : Daniel Almansa, Jairo Pastor, Raúl Jurado y Sergio Sánchez"
                + "\n");
        }
        //Abre el form de ayuda de esta ventana
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaEstadisticas aEstad = new AyudaEstadisticas();
            aEstad.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}