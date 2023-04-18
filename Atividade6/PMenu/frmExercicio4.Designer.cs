namespace PMenu
{
    partial class frmExercicio4
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
            this.rchtxtTextao = new System.Windows.Forms.RichTextBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtBlank = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rchtxtTextao
            // 
            this.rchtxtTextao.Location = new System.Drawing.Point(312, 95);
            this.rchtxtTextao.Name = "rchtxtTextao";
            this.rchtxtTextao.Size = new System.Drawing.Size(581, 245);
            this.rchtxtTextao.TabIndex = 0;
            this.rchtxtTextao.Text = "";
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(312, 403);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(165, 63);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Quantidade de Números";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.Location = new System.Drawing.Point(518, 403);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(165, 63);
            this.btnBlank.TabIndex = 2;
            this.btnBlank.Text = "Posição do Primeiro Espaço em Branco";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(728, 403);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(165, 63);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantidade de Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(345, 507);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ReadOnly = true;
            this.txtNumeros.Size = new System.Drawing.Size(100, 26);
            this.txtNumeros.TabIndex = 4;
            this.txtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBlank
            // 
            this.txtBlank.Location = new System.Drawing.Point(551, 507);
            this.txtBlank.Name = "txtBlank";
            this.txtBlank.ReadOnly = true;
            this.txtBlank.Size = new System.Drawing.Size(100, 26);
            this.txtBlank.TabIndex = 5;
            this.txtBlank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(765, 507);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.ReadOnly = true;
            this.txtLetras.Size = new System.Drawing.Size(100, 26);
            this.txtLetras.TabIndex = 6;
            this.txtLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtBlank);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rchtxtTextao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTextao;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtBlank;
        private System.Windows.Forms.TextBox txtLetras;
    }
}