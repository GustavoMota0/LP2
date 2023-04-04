using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoImposto
{
    public partial class Imposto : Form
    {
        double salarioBruto, salarioFamilia, salarioLiquido, descontoInss, descontoIrpf;

        public Imposto()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            mskbxAliquotaInss.Clear();
            mskbxAliquotaIrpf.Clear();
            mskbxDescontoInss.Clear();
            mskbxDescontoIrpf.Clear();

            if ((txtNome.Text != "") && (txtSobrenome.Text != "") && ((rbtnFeminino.Checked == true) || (rbtnMasculino.Checked == true)))
            {
                salarioBruto = Convert.ToDouble(mskbxSalario.Text);

                if (salarioBruto <= 800.47)
                {
                    mskbxAliquotaInss.Text = "7,65%";
                    descontoInss = 0.0765 * salarioBruto;
                    mskbxDescontoInss.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 1050)
                {
                    mskbxAliquotaInss.Text = "8,65%";
                    descontoInss = 0.0865 * salarioBruto;
                    mskbxDescontoInss.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 1400.77)
                {
                    mskbxAliquotaInss.Text = "9,00%";
                    descontoInss = 0.09 * salarioBruto;
                    mskbxDescontoInss.Text = descontoInss.ToString();
                }
                else if (salarioBruto <= 2801.56)
                {
                    mskbxAliquotaInss.Text = "11,00%";
                    descontoInss = 0.11 * salarioBruto;
                    mskbxDescontoInss.Text = descontoInss.ToString();
                }
                else if (salarioBruto > 2801.56)
                {
                    mskbxAliquotaInss.Text = "308,17";
                    descontoInss = 308.17;
                    mskbxDescontoInss.Text = descontoInss.ToString();
                }
                if (salarioBruto <= 1257.12)
                {
                    mskbxAliquotaIrpf.Text = "Isento";
                    descontoIrpf = 0;
                    mskbxDescontoIrpf.Text = "0";
                }
                else if (salarioBruto <= 2512.08)
                {
                    mskbxAliquotaIrpf.Text = "15,00%";
                    descontoIrpf = 0.15 * salarioBruto;
                    mskbxDescontoIrpf.Text = descontoIrpf.ToString();
                }
                else if (salarioBruto > 2512.08)
                {
                    mskbxAliquotaIrpf.Text = "27,50%";
                    descontoIrpf = 0.275 * salarioBruto;
                    mskbxDescontoIrpf.Text = descontoIrpf.ToString();
                }
                if (salarioBruto < 435.52)
                {
                    salarioFamilia = Convert.ToDouble(nudFilhos.Text) * 22.33;
                    mskbxSalarioFamilia.Text = salarioFamilia.ToString();
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = Convert.ToDouble(nudFilhos.Text) * 15.74;
                    mskbxSalarioFamilia.Text = salarioFamilia.ToString();
                }
                else mskbxSalarioFamilia.Text = "0";

                salarioLiquido = salarioBruto - descontoIrpf - descontoInss;

                mskbxSalarioLiquido.Text = salarioLiquido.ToString();

                if ((rbtnFeminino.Checked == true) && (rbtnCasado.Checked == false))
                {
                    rchtxtFrase.Text = "Os descontos da Srta. " + txtNome.Text + " " + txtSobrenome.Text + " que possui " + nudFilhos.Text + " filho(s)";
                }
                else if ((rbtnFeminino.Checked == true) && (rbtnCasado.Checked== true))
                {
                    rchtxtFrase.Text = "Os descontos da Sra. " + txtNome.Text + " " + txtSobrenome.Text + " que possui " + nudFilhos.Text + " filho(s)";
                }
                else if ((rbtnMasculino.Checked == true) && (rbtnCasado.Checked == true))
                {
                    rchtxtFrase.Text = "Os descontos do Sr. " + txtNome.Text + " " + txtSobrenome.Text + " que possui " + nudFilhos.Text + " filho(s)";
                }
                else if ((rbtnMasculino.Checked == true) && (rbtnCasado.Checked == false))
                {
                    rchtxtFrase.Text = "Os descontos da Srt. " + txtNome.Text + " " + txtSobrenome.Text + " que possui " + nudFilhos.Text + " filho(s)";
                }
            }
            else
                MessageBox.Show("Dados Inválidos");
        }
    }
}
