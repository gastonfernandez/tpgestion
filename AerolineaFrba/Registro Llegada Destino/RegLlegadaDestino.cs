using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegLlegada : Form
    {
        public RegLlegada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet2.CIUDAD' Puede moverla o quitarla según sea necesario.
            this.cIUDADTableAdapter2.Fill(this.gD2C2015DataSet2.CIUDAD);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet1.CIUDAD' Puede moverla o quitarla según sea necesario.
            this.cIUDADTableAdapter1.Fill(this.gD2C2015DataSet1.CIUDAD);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSetJ.CIUDAD' Puede moverla o quitarla según sea necesario.
            this.cIUDADTableAdapter.Fill(this.gD2C2015DataSetJ.CIUDAD);
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.obtenerVueloRegistroBindingSource1;
            this.obtenerVueloRegistroTableAdapter.Fill(this.gD2C2015DataSetJ.ObtenerVueloRegistro, txtMatricula.Text, comboBox1.Text, comboBox2.Text);
        }

    }
}
