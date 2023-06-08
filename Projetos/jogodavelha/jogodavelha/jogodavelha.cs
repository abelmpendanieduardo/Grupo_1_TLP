using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha
{
    public partial class Form1 : Form
    {           string l, c;

        int xpontos = 0, Opontos = 0, empatespontos = 0, rodadas = 0;

        bool turno = false, jogo_final = false;
        string[] texto =  new string [9];
        
        

        public Form1()
        {

            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int btnin = Convert.ToInt32(btn.TabIndex);
             if (btn.Text =="" && jogo_final ==false)
            {
                if (turno)
            {
                btn.Text = "X";
                    texto[btnin] = "X";
                turno = !turno;
                    btnin++;
                rodadas++;
                    checar(1);
            }
            else
            {

                    btn.Text = "O";
                    texto[btnin] = "O";
                    turno = !turno;
                    btnin++;
                    rodadas++;
                    checar(2);

                }


            }
        }

        private void limpar(object sender, EventArgs e)
        {
            again();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
           
            
        }


        private void checar(int ch)

        {
            //  bool form1 .vencedor;

            string a = "";

            if (ch == 1)

                a ="X";
            else
            {
                a = "O";
            }
            for (int i = 0; i < 8; i += 3)
            {
                if( a == texto[i])
                {
                    if (texto[i] == texto[i + 1] && texto[i] == texto[i + 2])
                    {
                         vencedor(a);
                        // again(); //nov();
                        return;
                    }
                }
            }
            //lihna 
            for (int i = 0; i < 3; i++)
            {
                if (a == texto[i])
                {
                    if (texto[i] == texto[i + 3] && texto[i] == texto[i + 6])
                    {
                          vencedor(a);
                        // again(); //nov();
                        return;
                    }
                }
            }
            //coluna
            if (a == texto[2] || a == texto[6] || a == texto[4])
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                      vencedor(a);
                    // again(); //nov();

                    return;
                }
            //se
            // secun
            if (a == texto[0] | a == texto[4] || a == texto[8])
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                     vencedor(a);
                    //prinagain();//nov();
                    return;
                }
            //prin
            if (rodadas == 9 && jogo_final == false)
            {
                 empate();
                return;
            }
        }
        private void vencedor(string e)
        {
            jogo_final = true;
            if (e == "X")
            {
                 MessageBox.Show("Parabens venceste...",lbl_xpontos .Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   int r = int.Parse(opontos.Text);
                r++;
                opontos.Text = r.ToString();
                turno = !turno;
            }
            else
            {
                MessageBox.Show("Parabens venceste...", lbl_opontos.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                int r2 = int.Parse(xpontosxpontos.Text);
                r2++;
                xpontosxpontos.Text = r2.ToString();
                turno = !turno;
            }
            
        }
        private void again()
        {
            btn_0.Text = "";
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            rodadas=0;
            jogo_final = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }
        private void empate()
        {
            MessageBox.Show("Empataram...", "Os jogadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jogo_final = true;
            int r = int.Parse(empates.Text);
            r++;
            empates.Text = r.ToString();
        }





    }
    }
    





















