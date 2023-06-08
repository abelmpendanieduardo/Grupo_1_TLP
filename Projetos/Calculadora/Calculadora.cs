using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
         public double valor1, valor2, resultado;
        public string operador;
        public bool inicio;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "9";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "+";
                valor1 = double.Parse(txtBoxOperacao.Text);
                txtBoxOperacao.Clear();
                lblOperacao.Text = valor1 + "+";
            }
            btnVirgula.Enabled = true;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                operador = "-";
                txtBoxOperacao.Text = "-";
                if (txtBoxOperacao.Text == "-" + Text)
                {
                    valor1 = double.Parse(txtBoxOperacao.Text);
                    txtBoxOperacao.Clear();
                    lblOperacao.Text = valor1 + "-";
                }
            }
            else
            {
                operador = "-";
                valor1 = double.Parse(txtBoxOperacao.Text);
                txtBoxOperacao.Clear();
                lblOperacao.Text = valor1 + "-";
            }
            btnVirgula.Enabled = true;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "x";
                valor1 = double.Parse(txtBoxOperacao.Text);
                txtBoxOperacao.Clear();
                lblOperacao.Text = valor1 + "x";
            }
            btnVirgula.Enabled = true;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "Inválido";
            }
            else if (txtBoxOperacao.Text == "Inválido")
                txtBoxOperacao.Text = "Inválido";
            else
            {
                operador = "/";
                valor1 = double.Parse(txtBoxOperacao.Text);
                txtBoxOperacao.Clear();
            }
            btnVirgula.Enabled = true;
        }

        private void btnLimparUm_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.TextLength > 1)
            {
                txtBoxOperacao.Text = txtBoxOperacao.Text.Remove(txtBoxOperacao.Text.Length - 1, 1);

            }
            if (txtBoxOperacao.Text.Length == 1)
            {
                txtBoxOperacao.Text = "0";
                inicio = true;
            }
            if (txtBoxOperacao.Text.Contains(","))
            {
                btnVirgula.Enabled = false;
            }
            else
            {
                btnVirgula.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxOperacao.Text = "";
            txtBoxOperacao.PlaceholderText = "0";
            lblOperacao.Text = "";
            btnVirgula.Enabled = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
             try
            {
                if(txtBoxOperacao.Text == "")
                    txtBoxOperacao.Text = "Inválido";
                else
                valor2 = double.Parse(txtBoxOperacao.Text);
            }
            catch { }

             switch (operador)
             {
                 case "+":
                     resultado = valor1 + valor2;
                     txtBoxOperacao.Text = resultado.ToString();
                     break;
                 case "-":
                     resultado = valor1 - valor2;
                     txtBoxOperacao.Text = resultado.ToString();
                     break;
                 case "x":

                     resultado = valor1 * valor2;

                     txtBoxOperacao.Text = resultado.ToString();
                     break;
                 case "/":
                     if (valor2 == 0)
                     {
                         txtBoxOperacao.Text = "Inválido";
                         MessageBox.Show("Insira um Valor Real.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         txtBoxOperacao.Text = "";
                     }
                     else
                     {
                         resultado = valor1 / valor2;
                         txtBoxOperacao.Text = resultado.ToString();
                     }
                     break;
             }
                    
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txtBoxOperacao.Text == "")
            {
                txtBoxOperacao.Text = "0,";
            }
            else
            {
                txtBoxOperacao.Text = txtBoxOperacao.Text + ",";
                btnVirgula.Enabled = false;
            }
        }
    }
}
