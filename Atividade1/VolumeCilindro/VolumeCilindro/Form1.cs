using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCilindro
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio deve ser um número");
                //txtRaio.Focus();
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura deve ser um número");
                //txtAltura.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtRaio.Text, out raio)) &&
                (double.TryParse(txtAltura.Text, out altura))&&
                (raio > 0) && (altura > 0))
            {
                volume = Math.Pow(raio, 2) * altura * Math.PI;
                txtVolume.Text = volume.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }
    }
}
