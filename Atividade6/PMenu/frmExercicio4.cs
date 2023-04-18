using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i <= rchtxtTextao.TextLength ; i++)
            {
                char numero = Convert.ToChar(rchtxtTextao.Text[i]);
                if ()
            }
            MessageBox.Show(quantidadeNumeros.ToString());
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            int i = 0, posicao = 0;
            while(i < 1)
            {
                Convert.ToChar(rchtxtTextao.Text[posicao]);
                if (char.IsWhiteSpace(rchtxtTextao.Text[posicao]) == false)
                    posicao += 1;
            }
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {

        }
    }
}
//int i, quantidadeNumeros = 0;
//for (i = 0; i <= rchtxtTextao.TextLength; i++)
//{
//    Convert.ToChar(rchtxtTextao.Text[i]);
//    if (char.IsNumber(rchtxtTextao.Text[i]) == true)
//        quantidadeNumeros += 1;
//}
//MessageBox.Show(quantidadeNumeros.ToString());