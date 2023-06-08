using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class janelapri : Form
    {
        string cor="";
        public janelapri()
        {
            InitializeComponent();
            cor = "k";
        }

        private void entrou(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }
        private void saiu(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Khaki;
        }

        private void btn_ini_Click(object sender, EventArgs e)
        {
            if (txt_jogadar1.Text != "" && txt_jogadar2.Text != "")
            {
                this.Hide();
                JanelaJogo h = new JanelaJogo(txt_jogadar1.Text, txt_jogadar2.Text,cor);
                h.Show();
            }
            else
            {
                MessageBox.Show("Verifique os campos", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_jogadar1.Select();
            }
        }
        private void Des(object sender, EventArgs e)
        {
            this.Hide();
            Desenvolvidores d = new Desenvolvidores();
            d.Show();
        }

        private void Jogoev(object sender, EventArgs e)
        {
            this.Hide();
            Sobre_Jogo f = new Sobre_Jogo();
            f.Show();
        }

        private void escuro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            cor = "e";
        }

        private void brancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            cor = "w";
        }

        private void beigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Khaki;
            cor = "k";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_jogar_Click(object sender, EventArgs e)
        {
            if (txt_jogadar1.Text != "" && txt_jogadar2.Text != "")
            {
                this.Hide();
              JanelaJogo j = new JanelaJogo(txt_jogadar1.Text, txt_jogadar2.Text,cor);
                j.Show();
            }
            else
            {
                MessageBox.Show("Verifique os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
