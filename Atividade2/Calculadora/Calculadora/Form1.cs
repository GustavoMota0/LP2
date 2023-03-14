using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Digite um número válido no Número 1");
                //txtNumero1.Focus();
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Digite um número válido no Número 2");
            }
        }

        private void btnSoma_Validated(object sender, EventArgs e)
        {

        }

        private void btnMenos_Validated(object sender, EventArgs e)
        {

        }

        private void btnMult_Validated(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Validated(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Validated(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                (double.TryParse(txtNumero2.Text, out numero2)) &&
                (numero2 > 0))
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }
    }
}
