namespace PMenu
{
    partial class frmExercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio2));
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.yilong = new System.Windows.Forms.PictureBox();
            this.btnMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yilong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(293, 133);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(293, 204);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(297, 348);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(112, 58);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "Verificar Igual";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(436, 348);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(112, 58);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir no Meio";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(436, 130);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(254, 26);
            this.txtPalavra1.TabIndex = 4;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(436, 201);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(254, 26);
            this.txtPalavra2.TabIndex = 5;
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(578, 348);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(112, 58);
            this.btnAsterisco.TabIndex = 6;
            this.btnAsterisco.Text = "Inserir Asterisco";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.BtnAsterisco_Click);
            // 
            // yilong
            // 
            this.yilong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yilong.BackgroundImage")));
            this.yilong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yilong.Location = new System.Drawing.Point(810, 37);
            this.yilong.Name = "yilong";
            this.yilong.Size = new System.Drawing.Size(320, 599);
            this.yilong.TabIndex = 7;
            this.yilong.TabStop = false;
            this.yilong.Visible = false;
            // 
            // btnMa
            // 
            this.btnMa.Location = new System.Drawing.Point(436, 484);
            this.btnMa.Name = "btnMa";
            this.btnMa.Size = new System.Drawing.Size(112, 58);
            this.btnMa.TabIndex = 8;
            this.btnMa.Text = "Yilong Ma";
            this.btnMa.UseVisualStyleBackColor = true;
            this.btnMa.Click += new System.EventHandler(this.BtnMa_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnMa);
            this.Controls.Add(this.yilong);
            this.Controls.Add(this.btnAsterisco);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.yilong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.PictureBox yilong;
        private System.Windows.Forms.Button btnMa;
    }
}