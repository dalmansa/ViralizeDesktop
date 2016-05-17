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

    public partial class Form1 : Form
    {
        String user;
        String pass;
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Form1()
        {
            InitializeComponent();
            //dataContext.RETOes.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string query = (from c in dataContext.USUARIOs
                            where c.username == txtUser.Text && c.password == txtPass.Text && c.administrador == 1
                            select c.username).FirstOrDefault();
            if (query != null)
            {
                Propuestas prop = new Propuestas();
                prop.Show();
            }
            else
                MessageBox.Show("Login incorrect");
        }





    }
    }
