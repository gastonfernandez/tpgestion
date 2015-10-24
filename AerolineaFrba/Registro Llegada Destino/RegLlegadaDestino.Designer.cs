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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetJ = new AerolineaFrba.GD2C2015DataSetJ();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cIUDADTableAdapter = new AerolineaFrba.GD2C2015DataSetJTableAdapters.CIUDADTableAdapter();
            this.obtenerVueloRegistroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerVueloRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerVueloRegistroTableAdapter = new AerolineaFrba.GD2C2015DataSetJTableAdapters.ObtenerVueloRegistroTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD2C2015DataSet1 = new AerolineaFrba.GD2C2015DataSet1();
            this.cIUDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cIUDADTableAdapter1 = new AerolineaFrba.GD2C2015DataSet1TableAdapters.CIUDADTableAdapter();
            this.gD2C2015DataSet2 = new AerolineaFrba.GD2C2015DataSet2();
            this.cIUDADBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cIUDADTableAdapter2 = new AerolineaFrba.GD2C2015DataSet2TableAdapters.CIUDADTableAdapter();
            this.gD2C2015DataSet3 = new AerolineaFrba.GD2C2015DataSet3();
            this.obtenerVueloRegistroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerVueloRegistroTableAdapter1 = new AerolineaFrba.GD2C2015DataSet3TableAdapters.ObtenerVueloRegistroTableAdapter();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEROMATRICULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vUELOFECHASALIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource2)).BeginInit();
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
            // cIUDADBindingSource
            // 
            this.cIUDADBindingSource.DataMember = "CIUDAD";
            this.cIUDADBindingSource.DataSource = this.gD2C2015DataSetJ;
            // 
            // gD2C2015DataSetJ
            // 
            this.gD2C2015DataSetJ.DataSetName = "GD2C2015DataSetJ";
            this.gD2C2015DataSetJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cIUDADTableAdapter
            // 
            this.cIUDADTableAdapter.ClearBeforeFill = true;
            // 
            // obtenerVueloRegistroBindingSource1
            // 
            this.obtenerVueloRegistroBindingSource1.DataMember = "ObtenerVueloRegistro";
            this.obtenerVueloRegistroBindingSource1.DataSource = this.gD2C2015DataSetJBindingSource;
            // 
            // gD2C2015DataSetJBindingSource
            // 
            this.gD2C2015DataSetJBindingSource.DataSource = this.gD2C2015DataSetJ;
            this.gD2C2015DataSetJBindingSource.Position = 0;
            // 
            // obtenerVueloRegistroBindingSource
            // 
            this.obtenerVueloRegistroBindingSource.DataMember = "ObtenerVueloRegistro";
            this.obtenerVueloRegistroBindingSource.DataSource = this.gD2C2015DataSetJBindingSource;
            // 
            // obtenerVueloRegistroTableAdapter
            // 
            this.obtenerVueloRegistroTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.aEROMATRICULADataGridViewTextBoxColumn,
            this.ciudadOrigenDataGridViewTextBoxColumn,
            this.ciudadDestinoDataGridViewTextBoxColumn,
            this.vUELOFECHASALIDADataGridViewTextBoxColumn,
            this.vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn,
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obtenerVueloRegistroBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // gD2C2015DataSet1
            // 
            this.gD2C2015DataSet1.DataSetName = "GD2C2015DataSet1";
            this.gD2C2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIUDADBindingSource1
            // 
            this.cIUDADBindingSource1.DataMember = "CIUDAD";
            this.cIUDADBindingSource1.DataSource = this.gD2C2015DataSet1;
            // 
            // cIUDADTableAdapter1
            // 
            this.cIUDADTableAdapter1.ClearBeforeFill = true;
            // 
            // gD2C2015DataSet2
            // 
            this.gD2C2015DataSet2.DataSetName = "GD2C2015DataSet2";
            this.gD2C2015DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIUDADBindingSource2
            // 
            this.cIUDADBindingSource2.DataMember = "CIUDAD";
            this.cIUDADBindingSource2.DataSource = this.gD2C2015DataSet2;
            // 
            // cIUDADTableAdapter2
            // 
            this.cIUDADTableAdapter2.ClearBeforeFill = true;
            // 
            // gD2C2015DataSet3
            // 
            this.gD2C2015DataSet3.DataSetName = "GD2C2015DataSet3";
            this.gD2C2015DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerVueloRegistroBindingSource2
            // 
            this.obtenerVueloRegistroBindingSource2.DataMember = "ObtenerVueloRegistro";
            this.obtenerVueloRegistroBindingSource2.DataSource = this.gD2C2015DataSet3;
            // 
            // obtenerVueloRegistroTableAdapter1
            // 
            this.obtenerVueloRegistroTableAdapter1.ClearBeforeFill = true;
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
            this.ciudadDestinoDataGridViewTextBoxColumn.DataSource = this.cIUDADBindingSource2;
            this.ciudadDestinoDataGridViewTextBoxColumn.DisplayMember = "CIUDAD_NOMBRE";
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
            // vUELOFECHALLEGADADataGridViewTextBoxColumn
            // 
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn.DataPropertyName = "VUELO_FECHA_LLEGADA";
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn.HeaderText = "Fecha Llegada";
            this.vUELOFECHALLEGADADataGridViewTextBoxColumn.Name = "vUELOFECHALLEGADADataGridViewTextBoxColumn";
            // 
            // RegLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegLlegada";
            this.Text = "Registro de Llegada de Vuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerVueloRegistroBindingSource2)).EndInit();
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
        private GD2C2015DataSetJ gD2C2015DataSetJ;
        private System.Windows.Forms.BindingSource cIUDADBindingSource;
        private GD2C2015DataSetJTableAdapters.CIUDADTableAdapter cIUDADTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource obtenerVueloRegistroBindingSource;
        private System.Windows.Forms.BindingSource gD2C2015DataSetJBindingSource;
        private GD2C2015DataSetJTableAdapters.ObtenerVueloRegistroTableAdapter obtenerVueloRegistroTableAdapter;
        private System.Windows.Forms.BindingSource obtenerVueloRegistroBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD2C2015DataSet1 gD2C2015DataSet1;
        private System.Windows.Forms.BindingSource cIUDADBindingSource1;
        private GD2C2015DataSet1TableAdapters.CIUDADTableAdapter cIUDADTableAdapter1;
        private GD2C2015DataSet2 gD2C2015DataSet2;
        private System.Windows.Forms.BindingSource cIUDADBindingSource2;
        private GD2C2015DataSet2TableAdapters.CIUDADTableAdapter cIUDADTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEROMATRICULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ciudadDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUELOFECHASALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUELOFECHALLEGADAESTIMADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUELOFECHALLEGADADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource obtenerVueloRegistroBindingSource2;
        private GD2C2015DataSet3 gD2C2015DataSet3;
        private GD2C2015DataSet3TableAdapters.ObtenerVueloRegistroTableAdapter obtenerVueloRegistroTableAdapter1;
    }
}