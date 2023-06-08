
namespace Alarme_version_2._0
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
            this.components = new System.ComponentModel.Container();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.lb_minuto = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.tb_minuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_desativar
            // 
            this.btn_desativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desativar.Location = new System.Drawing.Point(307, 163);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(89, 23);
            this.btn_desativar.TabIndex = 0;
            this.btn_desativar.Text = "DESATIVAR";
            this.btn_desativar.UseVisualStyleBackColor = true;
            this.btn_desativar.Click += new System.EventHandler(this.btn_desativar_Click);
            // 
            // btn_ativar
            // 
            this.btn_ativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ativar.Location = new System.Drawing.Point(224, 163);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(75, 23);
            this.btn_ativar.TabIndex = 1;
            this.btn_ativar.Text = "ATIVAR";
            this.btn_ativar.UseVisualStyleBackColor = true;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // lb_minuto
            // 
            this.lb_minuto.AutoSize = true;
            this.lb_minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_minuto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_minuto.Location = new System.Drawing.Point(221, 52);
            this.lb_minuto.Name = "lb_minuto";
            this.lb_minuto.Size = new System.Drawing.Size(56, 13);
            this.lb_minuto.TabIndex = 2;
            this.lb_minuto.Text = "MINUTO";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_hora.Location = new System.Drawing.Point(12, 52);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(42, 13);
            this.lb_hora.TabIndex = 3;
            this.lb_hora.Text = "HORA";
            // 
            // tb_hora
            // 
            this.tb_hora.Location = new System.Drawing.Point(60, 49);
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(100, 20);
            this.tb_hora.TabIndex = 4;
            // 
            // tb_minuto
            // 
            this.tb_minuto.Location = new System.Drawing.Point(283, 49);
            this.tb_minuto.Name = "tb_minuto";
            this.tb_minuto.Size = new System.Drawing.Size(100, 20);
            this.tb_minuto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(183, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(438, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_minuto);
            this.Controls.Add(this.tb_hora);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_minuto);
            this.Controls.Add(this.btn_ativar);
            this.Controls.Add(this.btn_desativar);
            this.Name = "Form1";
            this.Text = "Alarme version 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_desativar;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.Label lb_minuto;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.TextBox tb_hora;
        private System.Windows.Forms.TextBox tb_minuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        int hora;
        int minuto;
    }
}

