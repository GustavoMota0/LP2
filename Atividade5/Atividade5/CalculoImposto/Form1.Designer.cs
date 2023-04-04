namespace CalculoImposto
{
    partial class Imposto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imposto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mskbxAliquotaInss = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoInss = new System.Windows.Forms.MaskedTextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblIrpf = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.mskbxSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNomeApenas = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnCasado);
            this.panel1.Location = new System.Drawing.Point(625, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 41);
            this.panel1.TabIndex = 2;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(47, 7);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(82, 24);
            this.rbtnCasado.TabIndex = 0;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbSexo.Controls.Add(this.rbtnFeminino);
            this.gpbSexo.Controls.Add(this.rbtnMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(625, 281);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(175, 75);
            this.gpbSexo.TabIndex = 3;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(48, 16);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(48, 45);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(409, 281);
            this.mskbxSalario.Mask = "9999999.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(175, 26);
            this.mskbxSalario.TabIndex = 4;
            this.mskbxSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Location = new System.Drawing.Point(199, 242);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(204, 26);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome do Funcionário";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalario
            // 
            this.lblSalario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalario.Location = new System.Drawing.Point(199, 281);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(204, 26);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário do Funcionário";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilhos
            // 
            this.lblFilhos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilhos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilhos.Location = new System.Drawing.Point(199, 328);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(204, 28);
            this.lblFilhos.TabIndex = 7;
            this.lblFilhos.Text = "Número de filhos";
            this.lblFilhos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(409, 242);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 26);
            this.txtNome.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificar.Location = new System.Drawing.Point(590, 585);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(145, 59);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Calcular Imposto";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mskbxAliquotaInss);
            this.panel2.Controls.Add(this.mskbxAliquotaIrpf);
            this.panel2.Controls.Add(this.mskbxDescontoIrpf);
            this.panel2.Controls.Add(this.mskbxDescontoInss);
            this.panel2.Controls.Add(this.lblDesconto);
            this.panel2.Controls.Add(this.lblAliquota);
            this.panel2.Controls.Add(this.lblIrpf);
            this.panel2.Controls.Add(this.lblInss);
            this.panel2.Location = new System.Drawing.Point(199, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 148);
            this.panel2.TabIndex = 11;
            // 
            // mskbxAliquotaInss
            // 
            this.mskbxAliquotaInss.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mskbxAliquotaInss.Location = new System.Drawing.Point(152, 57);
            this.mskbxAliquotaInss.Name = "mskbxAliquotaInss";
            this.mskbxAliquotaInss.ReadOnly = true;
            this.mskbxAliquotaInss.Size = new System.Drawing.Size(138, 26);
            this.mskbxAliquotaInss.TabIndex = 17;
            this.mskbxAliquotaInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskbxAliquotaIrpf
            // 
            this.mskbxAliquotaIrpf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mskbxAliquotaIrpf.Location = new System.Drawing.Point(152, 108);
            this.mskbxAliquotaIrpf.Name = "mskbxAliquotaIrpf";
            this.mskbxAliquotaIrpf.ReadOnly = true;
            this.mskbxAliquotaIrpf.Size = new System.Drawing.Size(138, 26);
            this.mskbxAliquotaIrpf.TabIndex = 16;
            this.mskbxAliquotaIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskbxDescontoIrpf
            // 
            this.mskbxDescontoIrpf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mskbxDescontoIrpf.Location = new System.Drawing.Point(311, 108);
            this.mskbxDescontoIrpf.Name = "mskbxDescontoIrpf";
            this.mskbxDescontoIrpf.ReadOnly = true;
            this.mskbxDescontoIrpf.Size = new System.Drawing.Size(138, 26);
            this.mskbxDescontoIrpf.TabIndex = 16;
            this.mskbxDescontoIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskbxDescontoInss
            // 
            this.mskbxDescontoInss.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mskbxDescontoInss.Location = new System.Drawing.Point(311, 57);
            this.mskbxDescontoInss.Name = "mskbxDescontoInss";
            this.mskbxDescontoInss.ReadOnly = true;
            this.mskbxDescontoInss.Size = new System.Drawing.Size(138, 26);
            this.mskbxDescontoInss.TabIndex = 15;
            this.mskbxDescontoInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDesconto
            // 
            this.lblDesconto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesconto.Location = new System.Drawing.Point(311, 10);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(138, 26);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Desconto";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAliquota
            // 
            this.lblAliquota.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAliquota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAliquota.Location = new System.Drawing.Point(152, 10);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(138, 26);
            this.lblAliquota.TabIndex = 3;
            this.lblAliquota.Text = "Alíquota";
            this.lblAliquota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrpf
            // 
            this.lblIrpf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIrpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrpf.Location = new System.Drawing.Point(50, 108);
            this.lblIrpf.Name = "lblIrpf";
            this.lblIrpf.Size = new System.Drawing.Size(72, 26);
            this.lblIrpf.TabIndex = 2;
            this.lblIrpf.Text = "IRPF";
            this.lblIrpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInss
            // 
            this.lblInss.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInss.Location = new System.Drawing.Point(50, 57);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(72, 26);
            this.lblInss.TabIndex = 1;
            this.lblInss.Text = "INSS";
            this.lblInss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSalarioLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(199, 626);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(119, 26);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            this.lblSalarioLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSalarioFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(199, 585);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(119, 26);
            this.lblSalarioFamilia.TabIndex = 13;
            this.lblSalarioFamilia.Text = "Salário Família";
            this.lblSalarioFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(409, 330);
            this.nudFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(175, 26);
            this.nudFilhos.TabIndex = 14;
            this.nudFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mskbxSalarioFamilia
            // 
            this.mskbxSalarioFamilia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mskbxSalarioFamilia.Location = new System.Drawing.Point(324, 585);
            this.mskbxSalarioFamilia.Name = "mskbxSalarioFamilia";
            this.mskbxSalarioFamilia.ReadOnly = true;
            this.mskbxSalarioFamilia.Size = new System.Drawing.Size(172, 26);
            this.mskbxSalarioFamilia.TabIndex = 17;
            this.mskbxSalarioFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mskbxSalarioLiquido
            // 
            this.mskbxSalarioLiquido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mskbxSalarioLiquido.Location = new System.Drawing.Point(324, 626);
            this.mskbxSalarioLiquido.Name = "mskbxSalarioLiquido";
            this.mskbxSalarioLiquido.ReadOnly = true;
            this.mskbxSalarioLiquido.Size = new System.Drawing.Size(172, 26);
            this.mskbxSalarioLiquido.TabIndex = 18;
            this.mskbxSalarioLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(590, 242);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(210, 26);
            this.txtSobrenome.TabIndex = 19;
            // 
            // lblNomeApenas
            // 
            this.lblNomeApenas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomeApenas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeApenas.Location = new System.Drawing.Point(409, 198);
            this.lblNomeApenas.Name = "lblNomeApenas";
            this.lblNomeApenas.Size = new System.Drawing.Size(175, 26);
            this.lblNomeApenas.TabIndex = 20;
            this.lblNomeApenas.Text = "Nome";
            this.lblNomeApenas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSobrenome.Location = new System.Drawing.Point(625, 198);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(175, 26);
            this.lblSobrenome.TabIndex = 21;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rchtxtFrase.Location = new System.Drawing.Point(199, 371);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(385, 41);
            this.rchtxtFrase.TabIndex = 22;
            this.rchtxtFrase.Text = "";
            // 
            // Imposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1249, 692);
            this.Controls.Add(this.rchtxtFrase);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNomeApenas);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.mskbxSalarioLiquido);
            this.Controls.Add(this.mskbxSalarioFamilia);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Imposto";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblIrpf;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaInss;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaIrpf;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoIrpf;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoInss;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiquido;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblNomeApenas;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.RichTextBox rchtxtFrase;
    }
}

