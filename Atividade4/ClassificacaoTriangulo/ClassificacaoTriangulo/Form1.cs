using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificacaoTriangulo
{
    public partial class Form1 : Form
    {
        double lado1, lado2, lado3;

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(txtLado1.Text, out lado1)) ||
                (!double.TryParse(txtLado2.Text, out lado2)) ||
                (!double.TryParse(txtLado3.Text, out lado3)) ||
                (lado1 <= 0) || (lado2 <= 0) || (lado3 <= 0))
            {
                MessageBox.Show("Números inválidos");
            }
            else if ((lado1 == lado2) && (lado2 == lado3))
                txtTriangulo.Text = "É um triângulo equilátero";
            else if ((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
                txtTriangulo.Text = "É um triângulo escaleno";
            else if ((lado1 != lado2) && (lado2 == lado3))
                txtTriangulo.Text = "É um triângulo isósceles";
            else if ((lado1 != lado3) && (lado1 == lado2))
                txtTriangulo.Text = "É um triângulo isósceles";
            else if ((lado1 != lado2) && (lado1 == lado3))
                txtTriangulo.Text = "É um triângulo isósceles";
            else if ((lado2 != lado3) && (lado1 == lado2))
                txtTriangulo.Text = "É um triângulo isósceles";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
