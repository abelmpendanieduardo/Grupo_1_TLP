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
    public partial class Sobre_Jogo : Form
    {
        public Sobre_Jogo()
        {
            InitializeComponent();
        }
        private void entrou(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }
        private void saiu(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Khaki;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            janelapri j = new janelapri();
            j.Show();
        }
    }
}
