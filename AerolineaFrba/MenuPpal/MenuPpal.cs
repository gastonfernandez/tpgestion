using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Registro_Llegada_Destino;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Compra;

namespace AerolineaFrba.Menu
{
    public partial class MenuPpal : Form
    {
        public MenuPpal()
        {
            InitializeComponent();
        }

        private void aBMRolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeLlegadaADestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegLlegada frm = new Registro_Llegada_Destino.RegLlegada();
            frm.Show();
        }

       
        private void generarViajeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GeneracionViaje frm1 = new Generacion_Viaje.GeneracionViaje();
            frm1.Show();

        }

             
    }
}
