namespace ViralizeDesktop
{
    partial class gestionRetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionRetos));
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlVideoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIRALIZEDataSet2 = new ViralizeDesktop.VIRALIZEDataSet2();
            this.rETOTableAdapter = new ViralizeDesktop.VIRALIZEDataSet2TableAdapters.RETOTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.txtURLVideo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Name = "label9";
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
            this.fechaCaducidadDataGridViewTextBoxColumn,
            this.urlVideoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn,
            this.plataformaIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rETOBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            resources.ApplyResources(this.tituloDataGridViewTextBoxColumn, "tituloDataGridViewTextBoxColumn");
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            resources.ApplyResources(this.descripcionDataGridViewTextBoxColumn, "descripcionDataGridViewTextBoxColumn");
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "fechaPublicacion";
            resources.ApplyResources(this.fechaPublicacionDataGridViewTextBoxColumn, "fechaPublicacionDataGridViewTextBoxColumn");
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "fechaCaducidad";
            resources.ApplyResources(this.fechaCaducidadDataGridViewTextBoxColumn, "fechaCaducidadDataGridViewTextBoxColumn");
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlVideoDataGridViewTextBoxColumn
            // 
            this.urlVideoDataGridViewTextBoxColumn.DataPropertyName = "urlVideo";
            resources.ApplyResources(this.urlVideoDataGridViewTextBoxColumn, "urlVideoDataGridViewTextBoxColumn");
            this.urlVideoDataGridViewTextBoxColumn.Name = "urlVideoDataGridViewTextBoxColumn";
            this.urlVideoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "activo";
            resources.ApplyResources(this.activoDataGridViewTextBoxColumn, "activoDataGridViewTextBoxColumn");
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "usuarioID";
            resources.ApplyResources(this.usuarioIDDataGridViewTextBoxColumn, "usuarioIDDataGridViewTextBoxColumn");
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataformaIDDataGridViewTextBoxColumn
            // 
            this.plataformaIDDataGridViewTextBoxColumn.DataPropertyName = "plataformaID";
            resources.ApplyResources(this.plataformaIDDataGridViewTextBoxColumn, "plataformaIDDataGridViewTextBoxColumn");
            this.plataformaIDDataGridViewTextBoxColumn.Name = "plataformaIDDataGridViewTextBoxColumn";
            this.plataformaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rETOBindingSource
            // 
            this.rETOBindingSource.DataMember = "RETO";
            this.rETOBindingSource.DataSource = this.vIRALIZEDataSet2;
            // 
            // vIRALIZEDataSet2
            // 
            this.vIRALIZEDataSet2.DataSetName = "VIRALIZEDataSet2";
            this.vIRALIZEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rETOTableAdapter
            // 
            this.rETOTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkActivo
            // 
            resources.ApplyResources(this.checkActivo, "checkActivo");
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(this.txtDescripcion, "txtDescripcion");
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // txtTitulo
            // 
            resources.ApplyResources(this.txtTitulo, "txtTitulo");
            this.txtTitulo.Name = "txtTitulo";
            // 
            // nombre
            // 
            resources.ApplyResources(this.nombre, "nombre");
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre.Name = "nombre";
            // 
            // dateTimeInicio
            // 
            resources.ApplyResources(this.dateTimeInicio, "dateTimeInicio");
            this.dateTimeInicio.Name = "dateTimeInicio";
            // 
            // dateTimeFinal
            // 
            resources.ApplyResources(this.dateTimeFinal, "dateTimeFinal");
            this.dateTimeFinal.Name = "dateTimeFinal";
            // 
            // txtURLVideo
            // 
            resources.ApplyResources(this.txtURLVideo, "txtURLVideo");
            this.txtURLVideo.Name = "txtURLVideo";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Name = "label5";
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Name = "label6";
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.buttonAtras, "buttonAtras");
            this.buttonAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // gestionRetos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtURLVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.checkActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gestionRetos";
            this.Load += new System.EventHandler(this.gestionRetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VIRALIZEDataSet2 vIRALIZEDataSet2;
        private System.Windows.Forms.BindingSource rETOBindingSource;
        private VIRALIZEDataSet2TableAdapters.RETOTableAdapter rETOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlVideoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataformaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.TextBox txtURLVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}