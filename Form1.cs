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
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Form1()
        {
            InitializeComponent();
            //dataContext.RETOes.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Propuestas prop = new Propuestas();
            prop.Show();
        }
    }
}
