﻿using System;
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
        public gestionRetos()
        {
            InitializeComponent();
        }

        private void gestionRetos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIRALIZEDataSet2.RETO' table. You can move, or remove it, as needed.
            this.rETOTableAdapter.Fill(this.vIRALIZEDataSet2.RETO);

        }
    }
}
