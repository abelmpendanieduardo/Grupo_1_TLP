namespace VS_Player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFecharListOpcoes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbrir = new Guna.UI2.WinForms.Guna2Button();
            this.btnListOpcoes = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlayPause = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraDuracao = new System.Windows.Forms.Panel();
            this.lblVolume = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInicio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbarDuracao = new Guna.UI2.WinForms.Guna2TrackBar();
            this.mPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.txtinPlayList = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.tSlider = new System.Windows.Forms.Timer(this.components);
            this.lblVSPlayer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.panelBarraDuracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlay)).BeginInit();
            this.pnlOpcoes.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlBotoes.Controls.Add(this.btnFecharListOpcoes);
            this.pnlBotoes.Controls.Add(this.btnAbrir);
            this.pnlBotoes.Controls.Add(this.btnListOpcoes);
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnAvancar);
            this.pnlBotoes.Controls.Add(this.btnPlayPause);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 448);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(827, 56);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnFecharListOpcoes
            // 
            this.btnFecharListOpcoes.BackgroundImage = global::VS_Player.Properties.Resources.toggle_off_48px1;
            this.btnFecharListOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharListOpcoes.BorderRadius = 10;
            this.btnFecharListOpcoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharListOpcoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharListOpcoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFecharListOpcoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFecharListOpcoes.FillColor = System.Drawing.Color.Transparent;
            this.btnFecharListOpcoes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFecharListOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnFecharListOpcoes.Location = new System.Drawing.Point(12, 14);
            this.btnFecharListOpcoes.Name = "btnFecharListOpcoes";
            this.btnFecharListOpcoes.Size = new System.Drawing.Size(34, 26);
            this.btnFecharListOpcoes.TabIndex = 5;
            this.btnFecharListOpcoes.Click += new System.EventHandler(this.btnFecharListOpcoes_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImage = global::VS_Player.Properties.Resources.file_explorer_48px;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbrir.BorderRadius = 10;
            this.btnAbrir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbrir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbrir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbrir.FillColor = System.Drawing.Color.Transparent;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(47, 14);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(33, 26);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnListOpcoes
            // 
            this.btnListOpcoes.BackgroundImage = global::VS_Player.Properties.Resources.toggle_on_48px;
            this.btnListOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListOpcoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListOpcoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListOpcoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListOpcoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListOpcoes.FillColor = System.Drawing.Color.Transparent;
            this.btnListOpcoes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnListOpcoes.Location = new System.Drawing.Point(8, 14);
            this.btnListOpcoes.Name = "btnListOpcoes";
            this.btnListOpcoes.Size = new System.Drawing.Size(34, 26);
            this.btnListOpcoes.TabIndex = 3;
            this.btnListOpcoes.Visible = false;
            this.btnListOpcoes.Click += new System.EventHandler(this.btnListOpcoes_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::VS_Player.Properties.Resources.skip_to_start_48px;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.BorderRadius = 10;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(312, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 45);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackgroundImage = global::VS_Player.Properties.Resources.end_48px;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvancar.BorderRadius = 10;
            this.btnAvancar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvancar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvancar.FillColor = System.Drawing.Color.Transparent;
            this.btnAvancar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(430, 3);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(53, 45);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = global::VS_Player.Properties.Resources.play_48px;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlayPause.BorderRadius = 10;
            this.btnPlayPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayPause.FillColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(371, 3);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(53, 45);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // panelBarraDuracao
            // 
            this.panelBarraDuracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelBarraDuracao.Controls.Add(this.lblVolume);
            this.panelBarraDuracao.Controls.Add(this.lblFim);
            this.panelBarraDuracao.Controls.Add(this.lblInicio);
            this.panelBarraDuracao.Controls.Add(this.tbarVolume);
            this.panelBarraDuracao.Controls.Add(this.tbarDuracao);
            this.panelBarraDuracao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarraDuracao.Location = new System.Drawing.Point(0, 412);
            this.panelBarraDuracao.Name = "panelBarraDuracao";
            this.panelBarraDuracao.Size = new System.Drawing.Size(827, 36);
            this.panelBarraDuracao.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.ForeColor = System.Drawing.Color.Cyan;
            this.lblVolume.Location = new System.Drawing.Point(802, 10);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(15, 15);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "30";
            // 
            // lblFim
            // 
            this.lblFim.BackColor = System.Drawing.Color.Transparent;
            this.lblFim.ForeColor = System.Drawing.Color.Cyan;
            this.lblFim.Location = new System.Drawing.Point(684, 10);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(24, 15);
            this.lblFim.TabIndex = 3;
            this.lblFim.Text = "0:00";
            // 
            // lblInicio
            // 
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.ForeColor = System.Drawing.Color.Cyan;
            this.lblInicio.Location = new System.Drawing.Point(3, 10);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(24, 15);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "0:00";
            // 
            // tbarVolume
            // 
            this.tbarVolume.Location = new System.Drawing.Point(718, 8);
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(82, 20);
            this.tbarVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbarVolume.TabIndex = 1;
            this.tbarVolume.ThumbColor = System.Drawing.Color.Aqua;
            this.tbarVolume.Value = 30;
            this.tbarVolume.ValueChanged += new System.EventHandler(this.tbarVolume_ValueChanged);
            // 
            // tbarDuracao
            // 
            this.tbarDuracao.Location = new System.Drawing.Point(46, 6);
            this.tbarDuracao.Name = "tbarDuracao";
            this.tbarDuracao.Size = new System.Drawing.Size(623, 23);
            this.tbarDuracao.TabIndex = 0;
            this.tbarDuracao.ThumbColor = System.Drawing.Color.Aqua;
            this.tbarDuracao.Value = 0;
            this.tbarDuracao.ValueChanged += new System.EventHandler(this.tbarDuracao_ValueChanged);
            // 
            // mPlay
            // 
            this.mPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPlay.Enabled = true;
            this.mPlay.Location = new System.Drawing.Point(0, 0);
            this.mPlay.Name = "mPlay";
            this.mPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mPlay.OcxState")));
            this.mPlay.Size = new System.Drawing.Size(827, 412);
            this.mPlay.TabIndex = 2;
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlOpcoes.Controls.Add(this.txtinPlayList);
            this.pnlOpcoes.Controls.Add(this.guna2HtmlLabel1);
            this.pnlOpcoes.Controls.Add(this.btnSair);
            this.pnlOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpcoes.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(144, 412);
            this.pnlOpcoes.TabIndex = 3;
            this.pnlOpcoes.Visible = false;
            // 
            // txtinPlayList
            // 
            this.txtinPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtinPlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinPlayList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinPlayList.ForeColor = System.Drawing.Color.Aqua;
            this.txtinPlayList.Location = new System.Drawing.Point(3, 28);
            this.txtinPlayList.Multiline = true;
            this.txtinPlayList.Name = "txtinPlayList";
            this.txtinPlayList.Size = new System.Drawing.Size(138, 325);
            this.txtinPlayList.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 9);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 21);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Title";
            // 
            // btnSair
            // 
            this.btnSair.BorderRadius = 10;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic);
            this.btnSair.ForeColor = System.Drawing.Color.Cyan;
            this.btnSair.Image = global::VS_Player.Properties.Resources.exit_48px;
            this.btnSair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSair.Location = new System.Drawing.Point(0, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 34);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tSlider
            // 
            this.tSlider.Enabled = true;
            this.tSlider.Tick += new System.EventHandler(this.tSlider_Tick);
            // 
            // lblVSPlayer
            // 
            this.lblVSPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblVSPlayer.Font = new System.Drawing.Font("Cambria", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSPlayer.ForeColor = System.Drawing.Color.Aqua;
            this.lblVSPlayer.Location = new System.Drawing.Point(139, 133);
            this.lblVSPlayer.Name = "lblVSPlayer";
            this.lblVSPlayer.Size = new System.Drawing.Size(410, 114);
            this.lblVSPlayer.TabIndex = 4;
            this.lblVSPlayer.Text = "VS Player";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel.Controls.Add(this.lblVSPlayer);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(144, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(683, 412);
            this.panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 504);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlOpcoes);
            this.Controls.Add(this.mPlay);
            this.Controls.Add(this.panelBarraDuracao);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBotoes.ResumeLayout(false);
            this.panelBarraDuracao.ResumeLayout(false);
            this.panelBarraDuracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlay)).EndInit();
            this.pnlOpcoes.ResumeLayout(false);
            this.pnlOpcoes.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private Guna.UI2.WinForms.Guna2Button btnListOpcoes;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2Button btnAvancar;
        private Guna.UI2.WinForms.Guna2Button btnPlayPause;
        private System.Windows.Forms.Panel panelBarraDuracao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVolume;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInicio;
        private Guna.UI2.WinForms.Guna2TrackBar tbarVolume;
        private Guna.UI2.WinForms.Guna2TrackBar tbarDuracao;
        private AxWMPLib.AxWindowsMediaPlayer mPlay;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.Timer tSlider;
        private Guna.UI2.WinForms.Guna2Button btnAbrir;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2Button btnFecharListOpcoes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVSPlayer;
        private System.Windows.Forms.TextBox txtinPlayList;
        private System.Windows.Forms.Panel panel;
    }
}

