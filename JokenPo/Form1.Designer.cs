namespace JokenPo
{
    partial class Form1
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
            System.Windows.Forms.Button btnPedra;
            this.labelTitulo = new System.Windows.Forms.Label();
            this.voce = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.vs = new System.Windows.Forms.Label();
            this.igual = new System.Windows.Forms.Label();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnPedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(776, 82);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Escolha:  Pedra , Papel ou Tesoura  .....";
            // 
            // voce
            // 
            this.voce.AutoSize = true;
            this.voce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voce.ForeColor = System.Drawing.SystemColors.Highlight;
            this.voce.Location = new System.Drawing.Point(80, 192);
            this.voce.Name = "voce";
            this.voce.Size = new System.Drawing.Size(65, 25);
            this.voce.TabIndex = 4;
            this.voce.Text = "Você";
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pc.Location = new System.Drawing.Point(374, 192);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(43, 25);
            this.pc.TabIndex = 5;
            this.pc.Text = "PC";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultado.Location = new System.Drawing.Point(665, 192);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(25, 25);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "?";
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vs.Location = new System.Drawing.Point(237, 192);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(42, 25);
            this.vs.TabIndex = 7;
            this.vs.Text = "VS";
            // 
            // igual
            // 
            this.igual.AutoSize = true;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.igual.Location = new System.Drawing.Point(523, 192);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(25, 25);
            this.igual.TabIndex = 8;
            this.igual.Text = "=";
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::JokenPo.Properties.Resources.Tesoura;
            this.btnTesoura.Location = new System.Drawing.Point(573, 346);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(200, 151);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::JokenPo.Properties.Resources.Papel;
            this.btnPapel.Location = new System.Drawing.Point(296, 346);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(200, 151);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            btnPedra.BackgroundImage = global::JokenPo.Properties.Resources.Pedra;
            btnPedra.Location = new System.Drawing.Point(19, 346);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new System.Drawing.Size(200, 151);
            btnPedra.TabIndex = 9;
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // picResultado
            // 
            this.picResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResultado.Location = new System.Drawing.Point(573, 106);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(200, 200);
            this.picResultado.TabIndex = 3;
            this.picResultado.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(296, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(btnPedra);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.voce);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label voce;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.Label igual;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
    }
}

