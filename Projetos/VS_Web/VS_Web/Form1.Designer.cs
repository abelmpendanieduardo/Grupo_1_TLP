namespace VS_Web
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.painelNavegacao = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGoogle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRecarregar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAvancar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tboxURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ptbox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.painelNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).BeginInit();
            this.SuspendLayout();
            // 
            // painelNavegacao
            // 
            this.painelNavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.painelNavegacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelNavegacao.Controls.Add(this.btnHome);
            this.painelNavegacao.Controls.Add(this.btnGoogle);
            this.painelNavegacao.Controls.Add(this.btnPesquisar);
            this.painelNavegacao.Controls.Add(this.btnRecarregar);
            this.painelNavegacao.Controls.Add(this.btnAvancar);
            this.painelNavegacao.Controls.Add(this.btnVoltar);
            this.painelNavegacao.Controls.Add(this.tboxURL);
            this.painelNavegacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelNavegacao.Location = new System.Drawing.Point(0, 0);
            this.painelNavegacao.Name = "painelNavegacao";
            this.painelNavegacao.Size = new System.Drawing.Size(803, 46);
            this.painelNavegacao.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackgroundImage = global::VS_Web.Properties.Resources.home_52px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.BorderColor = System.Drawing.Color.Aqua;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(83, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(22, 19);
            this.btnHome.TabIndex = 18;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogle.Animated = true;
            this.btnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogle.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoogle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoogle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoogle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoogle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoogle.FillColor = System.Drawing.Color.Transparent;
            this.btnGoogle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.ForeColor = System.Drawing.Color.White;
            this.btnGoogle.Image = global::VS_Web.Properties.Resources.google_48px;
            this.btnGoogle.Location = new System.Drawing.Point(687, 11);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnGoogle.Size = new System.Drawing.Size(22, 19);
            this.btnGoogle.TabIndex = 17;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.BackgroundImage = global::VS_Web.Properties.Resources.search_64px;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.BorderColor = System.Drawing.Color.Aqua;
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.FillColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(651, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPesquisar.Size = new System.Drawing.Size(19, 18);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Animated = true;
            this.btnRecarregar.BackgroundImage = global::VS_Web.Properties.Resources.refresh_64px;
            this.btnRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecarregar.BorderColor = System.Drawing.Color.Aqua;
            this.btnRecarregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecarregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecarregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecarregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecarregar.FillColor = System.Drawing.Color.Transparent;
            this.btnRecarregar.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnRecarregar.ForeColor = System.Drawing.Color.White;
            this.btnRecarregar.Location = new System.Drawing.Point(56, 12);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRecarregar.Size = new System.Drawing.Size(22, 19);
            this.btnRecarregar.TabIndex = 15;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Animated = true;
            this.btnAvancar.BackgroundImage = global::VS_Web.Properties.Resources.double_right_52px;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvancar.BorderColor = System.Drawing.Color.Aqua;
            this.btnAvancar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvancar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvancar.FillColor = System.Drawing.Color.Transparent;
            this.btnAvancar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(32, 12);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvancar.Size = new System.Drawing.Size(22, 19);
            this.btnAvancar.TabIndex = 14;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Animated = true;
            this.btnVoltar.BackgroundImage = global::VS_Web.Properties.Resources.double_left_52px;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.BorderColor = System.Drawing.Color.Aqua;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(4, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnVoltar.Size = new System.Drawing.Size(22, 19);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tboxURL
            // 
            this.tboxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxURL.Animated = true;
            this.tboxURL.BorderRadius = 10;
            this.tboxURL.BorderThickness = 0;
            this.tboxURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxURL.DefaultText = "";
            this.tboxURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxURL.FillColor = System.Drawing.Color.DimGray;
            this.tboxURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxURL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxURL.ForeColor = System.Drawing.Color.White;
            this.tboxURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxURL.Location = new System.Drawing.Point(114, 10);
            this.tboxURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxURL.Name = "tboxURL";
            this.tboxURL.PasswordChar = '\0';
            this.tboxURL.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxURL.PlaceholderText = "Pesquisar";
            this.tboxURL.SelectedText = "";
            this.tboxURL.Size = new System.Drawing.Size(566, 24);
            this.tboxURL.TabIndex = 12;
            this.tboxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxURL_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 46);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(803, 461);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            // 
            // ptbox
            // 
            this.ptbox.BackColor = System.Drawing.Color.Transparent;
            this.ptbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbox.Image = global::VS_Web.Properties.Resources.computer_engineering_science_tech_wallpaper_preview;
            this.ptbox.ImageRotate = 0F;
            this.ptbox.Location = new System.Drawing.Point(0, 46);
            this.ptbox.Name = "ptbox";
            this.ptbox.Size = new System.Drawing.Size(803, 461);
            this.ptbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbox.TabIndex = 2;
            this.ptbox.TabStop = false;
            this.ptbox.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 507);
            this.Controls.Add(this.ptbox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.painelNavegacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(819, 546);
            this.Name = "Form1";
            this.Text = "VS_Web";
            this.painelNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel painelNavegacao;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbox;
        private Guna.UI2.WinForms.Guna2CircleButton btnHome;
        private Guna.UI2.WinForms.Guna2CircleButton btnGoogle;
        private Guna.UI2.WinForms.Guna2CircleButton btnPesquisar;
        private Guna.UI2.WinForms.Guna2CircleButton btnRecarregar;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvancar;
        private Guna.UI2.WinForms.Guna2CircleButton btnVoltar;
        private Guna.UI2.WinForms.Guna2TextBox tboxURL;

    }
}

