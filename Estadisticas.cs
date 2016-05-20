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
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            cargarChar1();
            

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

        private void cargarChar2()
        {
            DateTime inicio;
            DateTime final;
            int count = 0;
            DateTime dt = new DateTime();

            inicio = fechaInicio.Value;
            final = fechaFin.Value;

            var query = from fe in dataContext.SHAREs
                        group fe by fe.fechaPublicacion into g
                        select g;
            foreach (IGrouping<DateTime, SHARE> studentGroup in query) {
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
            return (input > date1 && input < date2);
        }

       

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            chartFechas.Series[0].Points.Clear();
            cargarChar2();
        }
    }
}
