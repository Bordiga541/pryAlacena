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
    public partial class frmAlacena : Form
    {
        //declaracion de variables

        string varLugar, varProducto, varTipo;

        int varCantidad;

        DateTime varFechaVencimiento;

        public frmAlacena()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mrcAlmacenado_Enter(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varLugar = cboLugar.Text;
            varProducto = cboProducto.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            varTipo = "";
            varFechaVencimiento = dtpFecha.Value;

            cboLugar2.Items.Add(varLugar);
            cboAlimento2.Items.Add(varProducto);
            lblCantidad3.Text = Convert.ToString(varCantidad);
            lblVencimiento2.Text = Convert.ToString(varFechaVencimiento);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            
        }
    }
}
