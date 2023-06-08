namespace JogoVelha
{
    partial class janelapri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janelapri));
            this.btn_jogar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_jogadar2 = new System.Windows.Forms.TextBox();
            this.txt_jogadar1 = new System.Windows.Forms.TextBox();
            this.menus = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claro = new System.Windows.Forms.ToolStripMenuItem();
            this.brancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuro = new System.Windows.Forms.ToolStripMenuItem();
            this.menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_jogar
            // 
            this.btn_jogar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_jogar.FlatAppearance.BorderSize = 3;
            this.btn_jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btn_jogar.Location = new System.Drawing.Point(62, 174);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(161, 51);
            this.btn_jogar.TabIndex = 19;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.btn_ini_Click);
            this.btn_jogar.MouseEnter += new System.EventHandler(this.entrou);
            this.btn_jogar.MouseLeave += new System.EventHandler(this.saiu);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderSize = 3;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btn_sair.Location = new System.Drawing.Point(235, 174);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(158, 51);
            this.btn_sair.TabIndex = 18;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseEnter += new System.EventHandler(this.entrou);
            this.btn_sair.MouseLeave += new System.EventHandler(this.saiu);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Jogador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jogador 1";
            // 
            // txt_jogadar2
            // 
            this.txt_jogadar2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jogadar2.Location = new System.Drawing.Point(235, 104);
            this.txt_jogadar2.MaxLength = 12;
            this.txt_jogadar2.Multiline = true;
            this.txt_jogadar2.Name = "txt_jogadar2";
            this.txt_jogadar2.Size = new System.Drawing.Size(213, 42);
            this.txt_jogadar2.TabIndex = 15;
            // 
            // txt_jogadar1
            // 
            this.txt_jogadar1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jogadar1.Location = new System.Drawing.Point(10, 104);
            this.txt_jogadar1.MaxLength = 12;
            this.txt_jogadar1.Multiline = true;
            this.txt_jogadar1.Name = "txt_jogadar1";
            this.txt_jogadar1.Size = new System.Drawing.Size(213, 42);
            this.txt_jogadar1.TabIndex = 14;
            // 
            // menus
            // 
            this.menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.definiçõesToolStripMenuItem});
            this.menus.Location = new System.Drawing.Point(0, 0);
            this.menus.Name = "menus";
            this.menus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menus.Size = new System.Drawing.Size(454, 24);
            this.menus.TabIndex = 20;
            this.menus.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvidoresToolStripMenuItem,
            this.jogoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // desenvolvidoresToolStripMenuItem
            // 
            this.desenvolvidoresToolStripMenuItem.Name = "desenvolvidoresToolStripMenuItem";
            this.desenvolvidoresToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.desenvolvidoresToolStripMenuItem.Text = "Desenvolvidores";
            this.desenvolvidoresToolStripMenuItem.Click += new System.EventHandler(this.Des);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.jogoToolStripMenuItem.Text = "Jogo";
            this.jogoToolStripMenuItem.Click += new System.EventHandler(this.Jogoev);
            // 
            // definiçõesToolStripMenuItem
            // 
            this.definiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claro,
            this.escuro});
            this.definiçõesToolStripMenuItem.Name = "definiçõesToolStripMenuItem";
            this.definiçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.definiçõesToolStripMenuItem.Text = "Definições";
            // 
            // claro
            // 
            this.claro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brancoToolStripMenuItem,
            this.beigeToolStripMenuItem});
            this.claro.Name = "claro";
            this.claro.Size = new System.Drawing.Size(152, 22);
            this.claro.Text = "Claro";
            // 
            // brancoToolStripMenuItem
            // 
            this.brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            this.brancoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brancoToolStripMenuItem.Text = "Branco";
            this.brancoToolStripMenuItem.Click += new System.EventHandler(this.brancoToolStripMenuItem_Click);
            // 
            // beigeToolStripMenuItem
            // 
            this.beigeToolStripMenuItem.Name = "beigeToolStripMenuItem";
            this.beigeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beigeToolStripMenuItem.Text = "Khaki";
            this.beigeToolStripMenuItem.Click += new System.EventHandler(this.beigeToolStripMenuItem_Click);
            // 
            // escuro
            // 
            this.escuro.Name = "escuro";
            this.escuro.Size = new System.Drawing.Size(152, 22);
            this.escuro.Text = "Escuro";
            this.escuro.Click += new System.EventHandler(this.escuro_Click);
            // 
            // janelapri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(454, 242);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_jogadar2);
            this.Controls.Add(this.txt_jogadar1);
            this.Controls.Add(this.menus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "janelapri";
            this.Text = "Jogo Guarita";
            this.menus.ResumeLayout(false);
            this.menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_jogadar2;
        public System.Windows.Forms.TextBox txt_jogadar1;
        private System.Windows.Forms.MenuStrip menus;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claro;
        private System.Windows.Forms.ToolStripMenuItem brancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuro;
    }
}

