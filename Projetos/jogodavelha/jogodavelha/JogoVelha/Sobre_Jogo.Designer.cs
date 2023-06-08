namespace JogoVelha
{
    partial class Sobre_Jogo
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_desr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_voltar.FlatAppearance.BorderSize = 3;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.Location = new System.Drawing.Point(5, 7);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(84, 39);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 100);
            this.label1.TabIndex = 8;
            this.label1.Text = "  Também pode ajudar a estimular o seu raciocínio pois terás de pensar nas posiçõ" +
    "es certas para conseguir vencer o jogo.\r\n\r\n";
            // 
            // lbl_desr
            // 
            this.lbl_desr.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.lbl_desr.Location = new System.Drawing.Point(0, 69);
            this.lbl_desr.Name = "lbl_desr";
            this.lbl_desr.Size = new System.Drawing.Size(493, 116);
            this.lbl_desr.TabIndex = 7;
            this.lbl_desr.Text = "  Neste jogo podes escolher em jogar com X ou O, isso por vez. Tenta colacar nas " +
    "posições que lhe possibilitarão vencer. Como, nas diagonais, verticais e horizon" +
    "tais";
            // 
            // Sobre_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(494, 265);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_desr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(510, 304);
            this.MinimumSize = new System.Drawing.Size(510, 304);
            this.Name = "Sobre_Jogo";
            this.Text = "Sobre_Jogo";
            this.MouseEnter += new System.EventHandler(this.entrou);
            this.MouseLeave += new System.EventHandler(this.saiu);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_desr;
    }
}