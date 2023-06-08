namespace JogoVelha
{
    partial class JanelaJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaJogo));
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.brn_2 = new System.Windows.Forms.Button();
            this.brn_5 = new System.Windows.Forms.Button();
            this.brn_4 = new System.Windows.Forms.Button();
            this.brn_3 = new System.Windows.Forms.Button();
            this.brn_8 = new System.Windows.Forms.Button();
            this.brn_7 = new System.Windows.Forms.Button();
            this.brn_6 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_j1 = new System.Windows.Forms.Label();
            this.lbl_emp = new System.Windows.Forms.Label();
            this.lbl_j2 = new System.Windows.Forms.Label();
            this.lbl_res_j1 = new System.Windows.Forms.Label();
            this.lbl_empates_numero = new System.Windows.Forms.Label();
            this.lbl_res_j2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(152, 42);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(101, 96);
            this.btn_0.TabIndex = 0;
            this.btn_0.Tag = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.btn_1.Location = new System.Drawing.Point(259, 42);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(101, 96);
            this.btn_1.TabIndex = 1;
            this.btn_1.Tag = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_2
            // 
            this.brn_2.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_2.Location = new System.Drawing.Point(366, 42);
            this.brn_2.Name = "brn_2";
            this.brn_2.Size = new System.Drawing.Size(101, 96);
            this.brn_2.TabIndex = 2;
            this.brn_2.Tag = "2";
            this.brn_2.UseVisualStyleBackColor = true;
            this.brn_2.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_5
            // 
            this.brn_5.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_5.Location = new System.Drawing.Point(366, 144);
            this.brn_5.Name = "brn_5";
            this.brn_5.Size = new System.Drawing.Size(101, 96);
            this.brn_5.TabIndex = 5;
            this.brn_5.Tag = "5";
            this.brn_5.UseVisualStyleBackColor = true;
            this.brn_5.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_4
            // 
            this.brn_4.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_4.Location = new System.Drawing.Point(259, 144);
            this.brn_4.Name = "brn_4";
            this.brn_4.Size = new System.Drawing.Size(101, 96);
            this.brn_4.TabIndex = 4;
            this.brn_4.Tag = "4";
            this.brn_4.UseVisualStyleBackColor = true;
            this.brn_4.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_3
            // 
            this.brn_3.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_3.Location = new System.Drawing.Point(152, 144);
            this.brn_3.Name = "brn_3";
            this.brn_3.Size = new System.Drawing.Size(101, 96);
            this.brn_3.TabIndex = 3;
            this.brn_3.Tag = "3";
            this.brn_3.UseVisualStyleBackColor = true;
            this.brn_3.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_8
            // 
            this.brn_8.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_8.Location = new System.Drawing.Point(366, 246);
            this.brn_8.Name = "brn_8";
            this.brn_8.Size = new System.Drawing.Size(101, 96);
            this.brn_8.TabIndex = 8;
            this.brn_8.Tag = "8";
            this.brn_8.UseVisualStyleBackColor = true;
            this.brn_8.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_7
            // 
            this.brn_7.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_7.Location = new System.Drawing.Point(259, 246);
            this.brn_7.Name = "brn_7";
            this.brn_7.Size = new System.Drawing.Size(101, 96);
            this.brn_7.TabIndex = 7;
            this.brn_7.Tag = "7";
            this.brn_7.UseVisualStyleBackColor = true;
            this.brn_7.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // brn_6
            // 
            this.brn_6.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold);
            this.brn_6.Location = new System.Drawing.Point(152, 246);
            this.brn_6.Name = "brn_6";
            this.brn_6.Size = new System.Drawing.Size(101, 96);
            this.brn_6.TabIndex = 6;
            this.brn_6.Tag = "6";
            this.brn_6.UseVisualStyleBackColor = true;
            this.brn_6.Click += new System.EventHandler(this.gerar_simbolo);
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_limpar.FlatAppearance.BorderSize = 4;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(226, 348);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(170, 54);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            this.btn_limpar.MouseEnter += new System.EventHandler(this.entrou);
            this.btn_limpar.MouseLeave += new System.EventHandler(this.saiu);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(43, 436);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(0, 13);
            this.lbl_1.TabIndex = 10;
            // 
            // lbl_j1
            // 
            this.lbl_j1.AutoSize = true;
            this.lbl_j1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_j1.Location = new System.Drawing.Point(5, 417);
            this.lbl_j1.Name = "lbl_j1";
            this.lbl_j1.Size = new System.Drawing.Size(110, 37);
            this.lbl_j1.TabIndex = 17;
            this.lbl_j1.Text = "label1";
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_emp.Location = new System.Drawing.Point(219, 417);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(150, 37);
            this.lbl_emp.TabIndex = 18;
            this.lbl_emp.Text = "Empates";
            // 
            // lbl_j2
            // 
            this.lbl_j2.AutoSize = true;
            this.lbl_j2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_j2.Location = new System.Drawing.Point(423, 417);
            this.lbl_j2.Name = "lbl_j2";
            this.lbl_j2.Size = new System.Drawing.Size(110, 37);
            this.lbl_j2.TabIndex = 19;
            this.lbl_j2.Text = "label3";
            // 
            // lbl_res_j1
            // 
            this.lbl_res_j1.AutoSize = true;
            this.lbl_res_j1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_res_j1.Location = new System.Drawing.Point(12, 467);
            this.lbl_res_j1.Name = "lbl_res_j1";
            this.lbl_res_j1.Size = new System.Drawing.Size(35, 37);
            this.lbl_res_j1.TabIndex = 20;
            this.lbl_res_j1.Text = "0";
            // 
            // lbl_empates_numero
            // 
            this.lbl_empates_numero.AutoSize = true;
            this.lbl_empates_numero.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_empates_numero.Location = new System.Drawing.Point(236, 467);
            this.lbl_empates_numero.Name = "lbl_empates_numero";
            this.lbl_empates_numero.Size = new System.Drawing.Size(35, 37);
            this.lbl_empates_numero.TabIndex = 21;
            this.lbl_empates_numero.Text = "0";
            // 
            // lbl_res_j2
            // 
            this.lbl_res_j2.AutoSize = true;
            this.lbl_res_j2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_res_j2.Location = new System.Drawing.Point(423, 467);
            this.lbl_res_j2.Name = "lbl_res_j2";
            this.lbl_res_j2.Size = new System.Drawing.Size(35, 37);
            this.lbl_res_j2.TabIndex = 22;
            this.lbl_res_j2.Text = "0";
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_voltar.FlatAppearance.BorderSize = 3;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 16.5F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.Location = new System.Drawing.Point(12, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(84, 39);
            this.btn_voltar.TabIndex = 23;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            this.btn_voltar.MouseEnter += new System.EventHandler(this.entrou);
            this.btn_voltar.MouseLeave += new System.EventHandler(this.saiu);
            // 
            // JanelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(606, 524);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_res_j2);
            this.Controls.Add(this.lbl_empates_numero);
            this.Controls.Add(this.lbl_res_j1);
            this.Controls.Add(this.lbl_j2);
            this.Controls.Add(this.lbl_emp);
            this.Controls.Add(this.lbl_j1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.brn_8);
            this.Controls.Add(this.brn_7);
            this.Controls.Add(this.brn_6);
            this.Controls.Add(this.brn_5);
            this.Controls.Add(this.brn_4);
            this.Controls.Add(this.brn_3);
            this.Controls.Add(this.brn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(622, 569);
            this.Name = "JanelaJogo";
            this.Text = "JanelaJogo";
            this.Load += new System.EventHandler(this.JanelaJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button brn_2;
        private System.Windows.Forms.Button brn_5;
        private System.Windows.Forms.Button brn_4;
        private System.Windows.Forms.Button brn_3;
        private System.Windows.Forms.Button brn_8;
        private System.Windows.Forms.Button brn_7;
        private System.Windows.Forms.Button brn_6;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_j1;
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Label lbl_j2;
        private System.Windows.Forms.Label lbl_res_j1;
        private System.Windows.Forms.Label lbl_empates_numero;
        private System.Windows.Forms.Label lbl_res_j2;
        private System.Windows.Forms.Button btn_voltar;
    }
}