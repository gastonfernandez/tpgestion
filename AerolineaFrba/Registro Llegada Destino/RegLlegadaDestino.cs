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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSetCiudad.CIUDAD' Puede moverla o quitarla según sea necesario.
            this.cIUDADTableAdapter.Fill(this.gD2C2015DataSetCiudad.CIUDAD);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet2.CIUDAD' Puede moverla o quitarla según sea necesario.

         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region Validacion de los campos de busqueda
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {

                MessageBox.Show("Debe completar los campos de búsqueda");

                return;

            }
            #endregion

            #region Ejecucion del SP ObtenerVueloRegistro, llenado de la grilla y Mensaje en caso de no encontrar nada
            this.dataGridView1.DataSource = this.obtenerVueloRegistroBindingSource;
            this.obtenerVueloRegistroTableAdapter.Fill(this.gD2C2015DataSetObtenerVueloRegistro.ObtenerVueloRegistro, txtMatricula.Text, comboBox1.Text, comboBox2.Text);
            if (this.gD2C2015DataSetObtenerVueloRegistro.ObtenerVueloRegistro.Rows.Count == 0 )
            {
                MessageBox.Show("No se encontraron resultados para el vuelo buscado");
            }
            #endregion
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellLeave(object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

                string fecha;
                fecha=dataGridView1.Columns["VueloFechaLlegada"].ToString();
                if (!EsFecha(fecha))
                {
                    MessageBox.Show("El campo Fecha de Llegada debe tener una fecha");
                }
            
            }

            
        }
       
        private Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
