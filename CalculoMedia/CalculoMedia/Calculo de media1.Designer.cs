namespace CalculoMedia
{
    partial class CalcMedia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNp1 = new System.Windows.Forms.Label();
            this.txtNp2 = new System.Windows.Forms.Label();
            this.txtPim = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.np1 = new System.Windows.Forms.TextBox();
            this.np2 = new System.Windows.Forms.TextBox();
            this.pim = new System.Windows.Forms.TextBox();
            this.zerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNp1
            // 
            this.txtNp1.AutoSize = true;
            this.txtNp1.Location = new System.Drawing.Point(39, 42);
            this.txtNp1.Name = "txtNp1";
            this.txtNp1.Size = new System.Drawing.Size(112, 13);
            this.txtNp1.TabIndex = 0;
            this.txtNp1.Text = "Digite a nota da NP1: ";
            // 
            // txtNp2
            // 
            this.txtNp2.AutoSize = true;
            this.txtNp2.Location = new System.Drawing.Point(39, 79);
            this.txtNp2.Name = "txtNp2";
            this.txtNp2.Size = new System.Drawing.Size(109, 13);
            this.txtNp2.TabIndex = 1;
            this.txtNp2.Text = "Digite a nota da NP2:";
            this.txtNp2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPim
            // 
            this.txtPim.AutoSize = true;
            this.txtPim.Location = new System.Drawing.Point(38, 115);
            this.txtPim.Name = "txtPim";
            this.txtPim.Size = new System.Drawing.Size(110, 13);
            this.txtPim.TabIndex = 2;
            this.txtPim.Text = "Digite a nota do PIM: ";
            this.txtPim.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(38, 201);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(72, 13);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "Sua média é: ";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(119, 159);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.descricao.Location = new System.Drawing.Point(341, 23);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(142, 13);
            this.descricao.TabIndex = 5;
            this.descricao.Text = "Calculo de média ponderada";
            this.descricao.Click += new System.EventHandler(this.label5_Click);
            // 
            // media
            // 
            this.media.AutoSize = true;
            this.media.Location = new System.Drawing.Point(116, 201);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(0, 13);
            this.media.TabIndex = 6;
            // 
            // np1
            // 
            this.np1.Location = new System.Drawing.Point(157, 39);
            this.np1.Name = "np1";
            this.np1.Size = new System.Drawing.Size(100, 20);
            this.np1.TabIndex = 7;
            this.np1.TextChanged += new System.EventHandler(this.np1_TextChanged);
            // 
            // np2
            // 
            this.np2.Location = new System.Drawing.Point(157, 76);
            this.np2.Name = "np2";
            this.np2.Size = new System.Drawing.Size(100, 20);
            this.np2.TabIndex = 8;
            // 
            // pim
            // 
            this.pim.Location = new System.Drawing.Point(157, 115);
            this.pim.Name = "pim";
            this.pim.Size = new System.Drawing.Size(100, 20);
            this.pim.TabIndex = 9;
            // 
            // zerar
            // 
            this.zerar.Enabled = false;
            this.zerar.Location = new System.Drawing.Point(109, 235);
            this.zerar.Name = "zerar";
            this.zerar.Size = new System.Drawing.Size(75, 23);
            this.zerar.TabIndex = 10;
            this.zerar.Text = "zerar";
            this.zerar.UseVisualStyleBackColor = true;
            this.zerar.Click += new System.EventHandler(this.zerar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.media);
            this.panel1.Controls.Add(this.zerar);
            this.panel1.Controls.Add(this.np1);
            this.panel1.Controls.Add(this.pim);
            this.panel1.Controls.Add(this.txtNp1);
            this.panel1.Controls.Add(this.resultado);
            this.panel1.Controls.Add(this.calcular);
            this.panel1.Controls.Add(this.np2);
            this.panel1.Controls.Add(this.txtNp2);
            this.panel1.Controls.Add(this.txtPim);
            this.panel1.Location = new System.Drawing.Point(256, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 283);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CalcMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.panel1);
            this.Name = "CalcMedia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNp1;
        private System.Windows.Forms.Label txtNp2;
        private System.Windows.Forms.Label txtPim;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.TextBox np1;
        private System.Windows.Forms.TextBox np2;
        private System.Windows.Forms.TextBox pim;
        private System.Windows.Forms.Button zerar;
        private System.Windows.Forms.Panel panel1;
    }
}

