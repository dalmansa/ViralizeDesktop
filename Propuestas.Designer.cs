namespace ViralizeDesktop
{
    partial class Propuestas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propuestas));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlVideoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPUESTARETOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIRALIZEDataSet = new ViralizeDesktop.VIRALIZEDataSet();
            this.pROPUESTA_RETOTableAdapter = new ViralizeDesktop.VIRALIZEDataSetTableAdapters.PROPUESTA_RETOTableAdapter();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.aProp = new System.Windows.Forms.Button();
            this.rProp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPropuestas = new System.Windows.Forms.Panel();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.crearUsuarioButton = new System.Windows.Forms.Button();
            this.checkSuper = new System.Windows.Forms.CheckBox();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPUESTARETOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelPropuestas.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propuestas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.urlVideoDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROPUESTARETOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(484, 253);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "fechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "fechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlVideoDataGridViewTextBoxColumn
            // 
            this.urlVideoDataGridViewTextBoxColumn.DataPropertyName = "urlVideo";
            this.urlVideoDataGridViewTextBoxColumn.HeaderText = "urlVideo";
            this.urlVideoDataGridViewTextBoxColumn.Name = "urlVideoDataGridViewTextBoxColumn";
            this.urlVideoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "usuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "usuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROPUESTARETOBindingSource
            // 
            this.pROPUESTARETOBindingSource.DataMember = "PROPUESTA_RETO";
            this.pROPUESTARETOBindingSource.DataSource = this.vIRALIZEDataSet;
            // 
            // vIRALIZEDataSet
            // 
            this.vIRALIZEDataSet.DataSetName = "VIRALIZEDataSet";
            this.vIRALIZEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROPUESTA_RETOTableAdapter
            // 
            this.pROPUESTA_RETOTableAdapter.ClearBeforeFill = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(521, 33);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(249, 328);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // aProp
            // 
            this.aProp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.aProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aProp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aProp.Location = new System.Drawing.Point(246, 302);
            this.aProp.Name = "aProp";
            this.aProp.Size = new System.Drawing.Size(120, 53);
            this.aProp.TabIndex = 7;
            this.aProp.Text = "Aceptar propuesta";
            this.aProp.UseVisualStyleBackColor = false;
            this.aProp.Click += new System.EventHandler(this.aProp_Click);
            // 
            // rProp
            // 
            this.rProp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rProp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rProp.Location = new System.Drawing.Point(93, 302);
            this.rProp.Name = "rProp";
            this.rProp.Size = new System.Drawing.Size(120, 53);
            this.rProp.TabIndex = 8;
            this.rProp.Text = "Rechazar propuesta";
            this.rProp.UseVisualStyleBackColor = false;
            this.rProp.Click += new System.EventHandler(this.rProp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propuestasToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // propuestasToolStripMenuItem
            // 
            this.propuestasToolStripMenuItem.Name = "propuestasToolStripMenuItem";
            this.propuestasToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.propuestasToolStripMenuItem.Text = "Propuestas";
            this.propuestasToolStripMenuItem.Click += new System.EventHandler(this.propuestasToolStripMenuItem_Click);
            // 
            // registroUsuariosToolStripMenuItem
            // 
            this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
            this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.registroUsuariosToolStripMenuItem.Text = "Registro usuarios";
            this.registroUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // panelPropuestas
            // 
            this.panelPropuestas.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.panelPropuestas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPropuestas.Controls.Add(this.label1);
            this.panelPropuestas.Controls.Add(this.rProp);
            this.panelPropuestas.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelPropuestas.Controls.Add(this.dataGridView1);
            this.panelPropuestas.Controls.Add(this.aProp);
            this.panelPropuestas.Location = new System.Drawing.Point(12, 37);
            this.panelPropuestas.Name = "panelPropuestas";
            this.panelPropuestas.Size = new System.Drawing.Size(859, 497);
            this.panelPropuestas.TabIndex = 10;
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.panelRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegistro.Controls.Add(this.crearUsuarioButton);
            this.panelRegistro.Controls.Add(this.checkSuper);
            this.panelRegistro.Controls.Add(this.checkAdmin);
            this.panelRegistro.Controls.Add(this.txtPassword);
            this.panelRegistro.Controls.Add(this.txtUsuario);
            this.panelRegistro.Controls.Add(this.txtApellidos);
            this.panelRegistro.Controls.Add(this.txtNombre);
            this.panelRegistro.Controls.Add(this.label8);
            this.panelRegistro.Controls.Add(this.label7);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Location = new System.Drawing.Point(15, 27);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(386, 361);
            this.panelRegistro.TabIndex = 11;
            // 
            // crearUsuarioButton
            // 
            this.crearUsuarioButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.crearUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crearUsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearUsuarioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearUsuarioButton.Location = new System.Drawing.Point(181, 269);
            this.crearUsuarioButton.Name = "crearUsuarioButton";
            this.crearUsuarioButton.Size = new System.Drawing.Size(120, 53);
            this.crearUsuarioButton.TabIndex = 15;
            this.crearUsuarioButton.Text = "Crear usuario";
            this.crearUsuarioButton.UseVisualStyleBackColor = false;
            this.crearUsuarioButton.Click += new System.EventHandler(this.crearUsuarioButton_Click);
            // 
            // checkSuper
            // 
            this.checkSuper.AutoSize = true;
            this.checkSuper.Location = new System.Drawing.Point(134, 229);
            this.checkSuper.Name = "checkSuper";
            this.checkSuper.Size = new System.Drawing.Size(15, 14);
            this.checkSuper.TabIndex = 14;
            this.checkSuper.UseVisualStyleBackColor = true;
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(134, 197);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkAdmin.TabIndex = 13;
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(134, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(134, 100);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(167, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(25, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Superusuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(25, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Administrador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(25, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro:";
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.panelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.button2);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.label9);
            this.panelAdmin.Location = new System.Drawing.Point(0, 27);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(694, 306);
            this.panelAdmin.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(430, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 53);
            this.button3.TabIndex = 18;
            this.button3.Text = "Estadisticas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(291, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "Gestion retos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(149, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Gestion usuarios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(18, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Administracion:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(700, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 24);
            this.button4.TabIndex = 19;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Propuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 409);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelPropuestas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Propuestas";
            this.Text = "Propuestas";
            this.Load += new System.EventHandler(this.Propuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPUESTARETOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPropuestas.ResumeLayout(false);
            this.panelPropuestas.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VIRALIZEDataSet vIRALIZEDataSet;
        private System.Windows.Forms.BindingSource pROPUESTARETOBindingSource;
        private VIRALIZEDataSetTableAdapters.PROPUESTA_RETOTableAdapter pROPUESTA_RETOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlVideoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button aProp;
        private System.Windows.Forms.Button rProp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
        private System.Windows.Forms.Panel panelPropuestas;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Button crearUsuarioButton;
        private System.Windows.Forms.CheckBox checkSuper;
        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}