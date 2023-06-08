using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarme_version_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            hora = int.Parse(tb_hora.Text);
            minuto = int.Parse(tb_minuto.Text);
            timer1.Enabled = true;
        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("alarme desativado");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hora == DateTime.Now.Hour && minuto == DateTime.Now.Minute)
            {
                timer1.Enabled = false;
                MessageBox.Show("Já está na hora");

            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("alarme ativado");
            }
        }
    }
}
