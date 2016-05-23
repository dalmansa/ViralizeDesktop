﻿using System;
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
        int id;
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIRALIZEDataSet3.RETO' table. You can move, or remove it, as needed.
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet3.RETO);
            cargarChar1();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void cargarChar1()
        {
            String nombreReto;
            int countShares = 0;

            var groupJoinQuery =
                from retos in dataContext.RETOes
                join shares in dataContext.SHAREs on retos.id equals shares.retoID into sharesGrup
                select new
                {
                    Reto = retos.titulo,
                    Shars = from share2 in sharesGrup
                            select share2
                };

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

        private void cargarChar2Concreto()
        {
            Boolean esReto = false;
            DateTime inicio;
            DateTime final;
            int count = 0;
            String dt = "";

            inicio = fechaInicio.Value;
            final = fechaFin.Value;

            var query = from fe in dataContext.SHAREs
                        orderby fe.fechaPublicacion
                        group fe by fe.fechaPublicacion into g
                        select g;
            foreach (IGrouping<DateTime, SHARE> studentGroup in query)
            {
                count = 0;
                esReto = false;
                foreach (SHARE fe in studentGroup)
                {
                   // esReto = (fe.retoID == id);
                    if (fe.retoID == id)
                    {
                        esReto = true;
                        if (Between(fe.fechaPublicacion, inicio, final)) {
                            MessageBox.Show(fe.fechaPublicacion.ToString());    
                            count ++;
                            dt = fe.fechaPublicacion.ToShortDateString();
                        }
                    }
                }
                if (esReto) {
                    MessageBox.Show("ENTRA");
                    chartFechas.Series["Shares"].Points.AddXY(dt, count);
                }
               
            }
        }

        private void cargarChar2()
        {
            DateTime inicio;
            DateTime final;
            int count = 0;
            DateTime dt = new DateTime();

            inicio = fechaInicio.Value;
            final = fechaFin.Value;

            var query = from fe in dataContext.SHAREs
                        orderby fe.fechaPublicacion
                        group fe by fe.fechaPublicacion into g
                        select g;
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

        public static bool Between(DateTime input, DateTime date1, DateTime date2)
        {
            return (input >= date1 && input <= date2);
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            chartFechas.Series[0].Points.Clear();
            cargarChar2();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartFechas.Series[0].Points.Clear();
            MessageBox.Show(id.ToString());
            cargarChar2Concreto();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            chartShares.Series[0].Points.Clear();

            DateTime inicio;
            DateTime final;
            inicio = fechaInicio2.Value;
            final = fechaFinal2.Value;
            Boolean entreFechas = false;

            String nombreReto;
            int countShares = 0;

            var groupJoinQuery =
                from retos in dataContext.RETOes
                join shares in dataContext.SHAREs on retos.id equals shares.retoID into sharesGrup
                select new
                {
                    Reto = retos.titulo,
                    Shars = from share2 in sharesGrup
                            select share2
                };

            foreach (var sharesGrup in groupJoinQuery)
            {
                countShares = 0;
                nombreReto = sharesGrup.Reto;
                foreach (var shareItem in sharesGrup.Shars)
                {
                    if (Between(shareItem.RETO.fechaPublicacion, inicio, final))
                    {
                        countShares = countShares + 1;
                        entreFechas = true;
                    }
                    else {
                        entreFechas = false;
                    }
                        
                }
                if (entreFechas) {
                    chartShares.Series["Shares"].Points.AddXY(nombreReto, countShares);
                }
                    
            }


        }
    }
}