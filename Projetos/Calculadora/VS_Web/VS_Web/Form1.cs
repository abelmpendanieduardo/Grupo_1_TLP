using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Funcionalidades de Navegacao

        private void navegar() 
        {
            webBrowser1.Navigate(tboxURL.Text);
            
        }

        private void tboxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (tboxURL.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    navegar();
                    ptbox.Visible = false;
                    webBrowser1.Visible = true;
                }
            }
            else if (tboxURL.Text == "" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Insira um URL", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboxURL.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tboxURL.Text != "")
            {
                navegar();
                ptbox.Visible = false;
                webBrowser1.Visible = true;
            }
            else
            {
                MessageBox.Show("Insira um URL", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboxURL.Focus();
            }
        }
        
        //Botoes de Navegacao PadrªAo

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            webBrowser1.Visible = false;
            ptbox.Visible = true;
            tboxURL.Text = "";
            tboxURL.PlaceholderText = "Pesquisar";
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(urlString: "google.com");
            tboxURL.Text = "google.com";
        }
    }
}
