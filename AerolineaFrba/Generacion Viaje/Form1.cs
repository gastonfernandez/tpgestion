using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarRutas();
            //CargarAeronaves; /* lu lo comente para compilar y probar lo mio del login*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.RUTA' Puede moverla o quitarla según sea necesario.
            this.rUTATableAdapter.Fill(this.gD2C2015DataSet.RUTA);

        }

        private void CargarRutas()
        {
            BasedeDatos bd = new BasedeDatos();
            bd.openConnection(); /* fijate que no hace falta hacer el open conection, simplemente hacer el select, dentro de ese metodo se hace un open y un close sino te va a pinchar*/
            string sSql = "SELECT * FROM VW_RUTAS";
            DataTable dt = bd.select_query(sSql);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void CargarAeronaves() 
        {
            BasedeDatos bd = new BasedeDatos();
            bd.openConnection();
        }

    }
}
