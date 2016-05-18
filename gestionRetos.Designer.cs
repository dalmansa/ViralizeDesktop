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
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vIRALIZEDataSet2 = new ViralizeDesktop.VIRALIZEDataSet2();
            this.rETOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rETOTableAdapter = new ViralizeDesktop.VIRALIZEDataSet2TableAdapters.RETOTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlVideoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Retos:";
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(514, 166);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // vIRALIZEDataSet2
            // 
            this.vIRALIZEDataSet2.DataSetName = "VIRALIZEDataSet2";
            this.vIRALIZEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rETOBindingSource
            // 
            this.rETOBindingSource.DataMember = "RETO";
            this.rETOBindingSource.DataSource = this.vIRALIZEDataSet2;
            // 
            // rETOTableAdapter
            // 
            this.rETOTableAdapter.ClearBeforeFill = true;
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
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlVideoDataGridViewTextBoxColumn
            // 
            this.urlVideoDataGridViewTextBoxColumn.DataPropertyName = "urlVideo";
            this.urlVideoDataGridViewTextBoxColumn.HeaderText = "urlVideo";
            this.urlVideoDataGridViewTextBoxColumn.Name = "urlVideoDataGridViewTextBoxColumn";
            this.urlVideoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "usuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "usuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataformaIDDataGridViewTextBoxColumn
            // 
            this.plataformaIDDataGridViewTextBoxColumn.DataPropertyName = "plataformaID";
            this.plataformaIDDataGridViewTextBoxColumn.HeaderText = "plataformaID";
            this.plataformaIDDataGridViewTextBoxColumn.Name = "plataformaIDDataGridViewTextBoxColumn";
            this.plataformaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(390, 225);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 53);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(138, 383);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(15, 14);
            this.checkActivo.TabIndex = 40;
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Activo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fecha final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha inicio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(138, 256);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(138, 227);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 32;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre.Location = new System.Drawing.Point(21, 225);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(51, 20);
            this.nombre.TabIndex = 31;
            this.nombre.Text = "Titulo:";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(138, 286);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInicio.TabIndex = 41;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Location = new System.Drawing.Point(138, 312);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFinal.TabIndex = 42;
            // 
            // txtURLVideo
            // 
            this.txtURLVideo.Location = new System.Drawing.Point(138, 350);
            this.txtURLVideo.Name = "txtURLVideo";
            this.txtURLVideo.Size = new System.Drawing.Size(100, 20);
            this.txtURLVideo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(21, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "URL Video:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(558, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 235);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // gestionRetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViralizeDesktop.Properties.Resources.colorBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 412);
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
            this.Name = "gestionRetos";
            this.Text = "gestionRetos";
            this.Load += new System.EventHandler(this.gestionRetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRALIZEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETOBindingSource)).EndInit();
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
    }
}