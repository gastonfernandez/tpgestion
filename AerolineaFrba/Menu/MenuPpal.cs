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
    }
}
