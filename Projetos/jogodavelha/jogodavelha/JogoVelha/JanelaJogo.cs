//using System;
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
    public partial class JanelaJogo : Form
    {
        
        string f, g;

        bool turno = true, jogo_f = false;
        string[] texto = new string[9];
        int xpo = 0, ypo = 0, emp = 0, rod = 0,q=0;
        bool y=false;
        string cor;
      

        public JanelaJogo(string j1,string j2,string c)
        {
            InitializeComponent();
            lbl_j1.Text = j1;
            lbl_j2.Text = j2;
            cor = c;
            if (cor == "e")
                this.BackColor = Color.Gray;
            if(cor=="w")
                this.BackColor = Color.White;
            if(cor=="k")
                this.BackColor = Color.Khaki;
            btn_voltar.Select();          
        }
        private void entrou(object sender,)
        {
            (sender as Button).BackColor = Color.Red;
        }
        private void saiu(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Khaki;
        }
        private void btn_limpar_MouseEnter(object sender, EventArgs e)
        {
            btn_limpar.BackColor = Color.Yellow;
        }

        private void btn_limpar_MouseLeave(object sender, EventArgs e)
        {
            
            btn_limpar.BackColor = Color.White;
        }

        private void JanelaJogo_Load(object sender, EventArgs e)
        {
         
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            janelapri h = new janelapri();
            h.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            janelapri j = new janelapri();
            j.Show();
        }

        private void gerar_simbolo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int btnin = Convert.ToInt32(btn.TabIndex),q=0;
            if (btn.Text == "" && jogo_f == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    texto[btnin] = "X";
                    turno = !turno;
                    rod++;
                    btnin++;
                    checar(1);
                   
                }
                else
                {
                    btn.Text = "O";
                    texto[btnin] = "O";
                    turno = !turno;
                    btnin++;
                    rod++;
                    checar(2);
                   
                }
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            again();

        }
        private void checar(int ch) 
        {
            string su = "";
            if (ch == 1)

                su = "X";
            else
            {
                su = "O";
            }
            for (int i = 0; i < 8; i+=3)
            {
                if (su==texto[i]) {
                    if (texto[i]== texto[i+1] && texto[i]== texto[i+2])
                    {
                        vencedor(su);
                            again(); //nov();
                        return;
                    }
                }
            }
            //horizontal
            for (int i = 0; i < 3; i ++)
            {
                if (su == texto[i])
                {
                    if (texto[i] == texto[i + 3] && texto[i] == texto[i + 6])
                    {
                        vencedor(su);
                            again(); //nov();
                        return;
                    }
                }
            }
            //vertical
            if (su == texto[2] || su == texto[8] || su == texto[4])
                if (texto[2] == texto[4] && texto[2] == texto[6])
                    {
                        vencedor(su); 
                    again();//nov();
                    return;
                    }
                    //sec
            if(su==texto[0]|| su == texto[4]|| su == texto[8])
                    if (texto[0] == texto[4] && texto[0] == texto[8])
                    {
                        vencedor(su);
                    again();//nov();
                    return;
                }
                    //prin
            if (rod==9 && jogo_f == false)
            {
                empate();
                return;
            }
        }
        private void vencedor(string e)
        {
           // jogo_f = true;
            if (e == "X")
            {
                MessageBox.Show("Parabens venceste...", lbl_j1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                int r = int.Parse(lbl_res_j1.Text);
                r++;
                lbl_res_j1.Text = r.ToString();
                turno = !turno;
            }
            else
            {
                MessageBox.Show("Parabens venceste...", lbl_j2.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                int r2 = int.Parse(lbl_res_j2.Text);
                r2++;
                lbl_res_j2.Text = r2.ToString();
            }
            btn_voltar.Select();
        }
    
        private void again()
        {
            btn_0.Text = "";
            btn_1.Text = "";
            brn_2.Text = "";
            brn_5.Text = "";
            brn_4.Text = "";
            brn_3.Text = "";
            brn_8.Text = "";
            brn_7.Text = "";
            brn_6.Text = "";
            rod = 0;
            jogo_f = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }           
        }
        
        private void empate()
        {
            MessageBox.Show("Empataram...","Os jogadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jogo_f = true;
            int r = int.Parse(lbl_empates_numero.Text);
            r++;
            lbl_empates_numero.Text = r.ToString();
        }
    }
}
