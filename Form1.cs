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
        //Variable que usamos para generar los hashes
        string hashkey = "ViralizeHashKey";
        //Variable para el control de login
        private String usernameIniciated;
        //Conexión que utilizamos para trabajar con la base de datos
        public VIRALIZEEntities dataContext = new VIRALIZEEntities();

        public string UsernameIniciated
        {
            get
            {
                return usernameIniciated;
            }

            set
            {
                usernameIniciated = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //dataContext.RETOes.Add();
        }
        //Evento de "Iniciar sesión"
        private void button1_Click(object sender, EventArgs e)
        {
            //Encriptamos la contraseña introducida en el login
            string hash = CreateSHAHash(txtPass.Text, hashkey);
            //Buscamos el usuario en la base de datos y comprobamos que sea administrador
            string query = (from c in dataContext.USUARIOs
                            where c.username == txtUser.Text && c.passw == hash && c.administrador == 1
                            select c.username).FirstOrDefault();
            //Si lo que devuelve no es null, pasa al siguiente form el nombre del usuario con el que hemos iniciado sesión
            if (query != null)
            {
                UsernameIniciated = txtUser.Text;
                using (Propuestas form2 = new Propuestas())
                {
                    form2.Logged = "Sesión iniciada como: "+usernameIniciated+"(admin)";
                    form2.ShowDialog();
                }
                //Propuestas prop = new Propuestas();
                //prop.ShowDialog();
            }
            else
                MessageBox.Show("Usuario/contraseña incorrectas");

        }

        //Método de encriptación para la contraseña
        public static string CreateSHAHash(string Text, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Text, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
