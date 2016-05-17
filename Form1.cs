﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Necesario para hash SHA512 */
using System.Security.Cryptography;

namespace ViralizeDesktop
{

    public partial class Form1 : Form
    {
        string hashkey = "ViralizeHashKey";

        public VIRALIZEEntities dataContext = new VIRALIZEEntities();
        public Form1()
        {
            InitializeComponent();
            //dataContext.RETOes.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hash = CreateSHAHash(txtPass.Text, hashkey);

            string query = (from c in dataContext.USUARIOs
                            where c.username == txtUser.Text && c.password == hash && c.administrador == 1
                            select c.username).FirstOrDefault();
            if (query != null)
            {
                Propuestas prop = new Propuestas();
                prop.Show();
            }
            else
                MessageBox.Show("Login incorrect");
        }


        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }



    }
    }
