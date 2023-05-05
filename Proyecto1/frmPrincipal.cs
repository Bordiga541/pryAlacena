using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdControlDeGastos_Click(object sender, EventArgs e)
        {
            frmGestionDeGastosMensuales ventanaControlDeGastosMensuales = new frmGestionDeGastosMensuales();

            ventanaControlDeGastosMensuales.ShowDialog();
        }

        private void cmdControlDeAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlacena = new frmAlacena();
            
            ventanaAlacena.ShowDialog();
        }
    }
}
