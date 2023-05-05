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
    public partial class frmGestionDeGastosMensuales : Form
    {
        //Declaracion de Variales
        decimal varDeposito, varAlquiler, varImpuesto,
            varComida, varGastosVarios, varSaldoRestante;


        public frmGestionDeGastosMensuales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtAlquiler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImpuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varGastosVarios = Convert.ToDecimal(txtMonto.Text);
            varImpuesto = Convert.ToDecimal(txtImpuestos.Text);
            varSaldoRestante = varDeposito - varAlquiler - varComida - varGastosVarios - varImpuesto;

            lblSaldoRestante2.Text = varSaldoRestante.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
