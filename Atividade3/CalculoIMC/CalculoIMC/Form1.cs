using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        double altura, peso, imc;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((!Double.TryParse(txtPeso.Text, out peso)) ||
                (!Double.TryParse(txtAltura.Text, out altura)) ||
                (peso <= 0) || (altura <= 0))
            {
                MessageBox.Show("Números inválidos");
            }
            else
            {
                imc = peso / Math.Pow(altura / 100, 2);
                if (imc < 18.5)
                {
                    txtFrase.Text = "A classificação para o IMC é magreza";
                }
                else if ((imc >= 18.5) && (imc < 25))
                {
                    txtFrase.Text = "A classificação para o IMC é normal";
                }
                else if ((imc >= 25) && (imc < 30))
                {
                    txtFrase.Text = "A classificação para o IMC é sobrepeso";
                }
                else if ((imc >= 30) && (imc < 40))
                {
                    txtFrase.Text = "A classificação para o IMC é obesidade";
                }
                else if (imc >= 40)
                {
                    txtFrase.Text = "A classificação para o IMC é obesidade grave";
                }
                imc = Math.Round(imc, 1);
                txtIMC.Text = imc.ToString();
            }
        }
    }
}
