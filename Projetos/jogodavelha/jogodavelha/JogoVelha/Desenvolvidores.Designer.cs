namespace JogoVelha
{
    partial class Desenvolvidores
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
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.lbl_desr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_voltar.FlatAppearance.BorderSize = 3;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.Location = new System.Drawing.Point(3, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(84, 39);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            this.btn_voltar.MouseEnter += new System.EventHandler(this.entrou);
            this.btn_voltar.MouseLeave += new System.EventHandler(this.saiu);
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.lbl_grupo.Location = new System.Drawing.Point(-2, 167);
            this.lbl_grupo.MaximumSize = new System.Drawing.Size(521, 109);
            this.lbl_grupo.MinimumSize = new System.Drawing.Size(521, 109);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(521, 109);
            this.lbl_grupo.TabIndex = 7;
            this.lbl_grupo.Text = "  O grupo é composto por seis integrantes, nomeadamente, Edvaldo Catimba, Paixão " +
    "de Barros, Uveli Afonso, Pedro Sadisso, Lucas  e Waldiniro. ";
            // 
            // lbl_desr
            // 
            this.lbl_desr.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.lbl_desr.Location = new System.Drawing.Point(-2, 62);
            this.lbl_desr.Name = "lbl_desr";
            this.lbl_desr.Size = new System.Drawing.Size(521, 116);
            this.lbl_desr.TabIndex = 6;
            this.lbl_desr.Text = "  Essa versão do \"Jogo da Velha\" foi criada pelo grupo número 6. Com intuito de m" +
    "ostrar que as suas ideias satisfazem a expectivas do nosso querido professor Nel" +
    "sonTito Mário. ";
            // 
            // Desenvolvidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(510, 304);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_desr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(510, 304);
            this.MinimumSize = new System.Drawing.Size(510, 304);
            this.Name = "Desenvolvidores";
            this.Text = "Desenvolvidores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbl_desr;
    }
}