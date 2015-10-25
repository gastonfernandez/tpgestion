namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegLlegada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetCiudad = new AerolineaFrba.GD2C2015DataSetCiudad();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.obtenerVueloRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetObtenerVueloRegistro = new AerolineaFrba.GD2C2015DataSetObtenerVueloRegistro();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cIUDADTableAdapter = new AerolineaFrba.GD2C2015DataSetCiudadTableAdapters.CIUDADTableAdapter();
            this.obtenerVueloRegistroTableAdapter = new AerolineaFrba.GD2C2015DataSetObtenerVueloRegistroTableAdapters.ObtenerVueloRegistroTableAdapter();
            this.ColumnaCambios = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEROMATRICULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vUELOFECHASALIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VueloFechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetObtenerVueloRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Vuelos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(760, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cIUDADBindingSource1;
            this.comboBox2.DisplayMember = "CIUDAD_NOMBRE";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(671, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "CIUDAD_NOMBRE";
            // 
            // cIUDADBindingSource1
            // 
            this.cIUDADBindingSource1.DataMember = "CIUDAD";
            this.cIUDADBindingSource1.DataSource = this.gD2C2015DataSetCiudad;
            // 
            // gD2C2015DataSetCiudad
            // 
            this.gD2C2015DataSetCiudad.DataSetName = "GD2C2015DataSetCiudad";
            this.gD2C2015DataSetCiudad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cIUDADBindingSource;
            this.comboBox1.DisplayMember = "CIUDAD_NOMBRE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(357, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "CIUDAD_NOMBRE";
            // 
            // cIUDADBindingSource
            // 
            this.cIUDADBindingSource.DataMember = "CIUDAD";
            this.cIUDADBindingSource.DataSource = this.gD2C2015DataSetCiudad;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(66, 35);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(153, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ciudad Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ciudad Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCambios,
            this.NroVuelo,
            this.aEROMATRICULADataGridViewTextBoxColumn,
            this.ciudadOrigenDataGridViewTextBoxColumn,
            this.ciudadDestinoDataGridViewTextBoxColumn,
            this.vUELOFECHASALIDADataGridViewTextBoxColumn,
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn,
            this.VueloFechaLlegada});
            this.dataGridView1.DataSource = this.obtenerVueloRegistroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(854, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // obtenerVueloRegistroBindingSource
            // 
            this.obtenerVueloRegistroBindingSource.DataMember = "ObtenerVueloRegistro";
            this.obtenerVueloRegistroBindingSource.DataSource = this.gD2C2015DataSetObtenerVueloRegistro;
            // 
            // gD2C2015DataSetObtenerVueloRegistro
            // 
            this.gD2C2015DataSetObtenerVueloRegistro.DataSetName = "GD2C2015DataSetObtenerVueloRegistro";
            this.gD2C2015DataSetObtenerVueloRegistro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(773, 455);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(84, 32);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar Datos";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cIUDADTableAdapter
            // 
            this.cIUDADTableAdapter.ClearBeforeFill = true;
            // 
            // obtenerVueloRegistroTableAdapter
            // 
            this.obtenerVueloRegistroTableAdapter.ClearBeforeFill = true;
            // 
            // ColumnaCambios
            // 
            this.ColumnaCambios.HeaderText = "";
            this.ColumnaCambios.Name = "ColumnaCambios";
            this.ColumnaCambios.ReadOnly = true;
            this.ColumnaCambios.Width = 20;
            // 
            // NroVuelo
            // 
            this.NroVuelo.DataPropertyName = "VUELO_ID";
            this.NroVuelo.HeaderText = "Nro. Vuelo";
            this.NroVuelo.Name = "NroVuelo";
            this.NroVuelo.ReadOnly = true;
            // 
            // aEROMATRICULADataGridViewTextBoxColumn
            // 
            this.aEROMATRICULADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aEROMATRICULADataGridViewTextBoxColumn.DataPropertyName = "AERO_MATRICULA";
            this.aEROMATRICULADataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.aEROMATRICULADataGridViewTextBoxColumn.Name = "aEROMATRICULADataGridViewTextBoxColumn";
            this.aEROMATRICULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadOrigenDataGridViewTextBoxColumn
            // 
            this.ciudadOrigenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadOrigenDataGridViewTextBoxColumn.DataPropertyName = "CiudadOrigen";
            this.ciudadOrigenDataGridViewTextBoxColumn.HeaderText = "Ciudad Origen";
            this.ciudadOrigenDataGridViewTextBoxColumn.Name = "ciudadOrigenDataGridViewTextBoxColumn";
            this.ciudadOrigenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDestinoDataGridViewTextBoxColumn
            // 
            this.ciudadDestinoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciudadDestinoDataGridViewTextBoxColumn.DataPropertyName = "CiudadDestino";
            this.ciudadDestinoDataGridViewTextBoxColumn.HeaderText = "Ciudad Destino";
            this.ciudadDestinoDataGridViewTextBoxColumn.Name = "ciudadDestinoDataGridViewTextBoxColumn";
            this.ciudadDestinoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ciudadDestinoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vUELOFECHASALIDADataGridViewTextBoxColumn
            // 
            this.vUELOFECHASALIDADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vUELOFECHASALIDADataGridViewTextBoxColumn.DataPropertyName = "VUELO_FECHA_SALIDA";
            this.vUELOFECHASALIDADataGridViewTextBoxColumn.HeaderText = "Fecha de Salida";
            this.vUELOFECHASALIDADataGridViewTextBoxColumn.Name = "vUELOFECHASALIDADataGridViewTextBoxColumn";
            this.vUELOFECHASALIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn
            // 
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn.DataPropertyName = "VUELO_FECHA_LLEGADA_ESTIMADA";
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn.HeaderText = "Fecha Estimada Llegada";
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn.Name = "vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn";
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VueloFechaLlegada
            // 
            this.VueloFechaLlegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VueloFechaLlegada.DataPropertyName = "VUELO_FECHA_LLEGADA";
            this.VueloFechaLlegada.HeaderText = "Fecha Llegada";
            this.VueloFechaLlegada.Name = "VueloFechaLlegada";
            // 
            // RegLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 499);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegLlegada";
            this.Text = "Registro de Llegada de Vuelos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetObtenerVueloRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGrabar;
        private GD2C2015DataSetCiudad gD2C2015DataSetCiudad;
        private System.Windows.Forms.BindingSource cIUDADBindingSource;
        private GD2C2015DataSetCiudadTableAdapters.CIUDADTableAdapter cIUDADTableAdapter;
        private System.Windows.Forms.BindingSource cIUDADBindingSource1;
        private System.Windows.Forms.BindingSource obtenerVueloRegistroBindingSource;
        private GD2C2015DataSetObtenerVueloRegistro gD2C2015DataSetObtenerVueloRegistro;
        private GD2C2015DataSetObtenerVueloRegistroTableAdapters.ObtenerVueloRegistroTableAdapter obtenerVueloRegistroTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEROMATRICULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ciudadDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUELOFECHASALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VueloFechaLlegada;
    }
}