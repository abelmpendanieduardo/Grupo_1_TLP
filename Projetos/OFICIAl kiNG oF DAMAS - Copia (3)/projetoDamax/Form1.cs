using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDamax
{
    public partial class Form1 : Form
    {
       //VARIAVEIS GLOBAIS USADAS...
        int altura =487,largura =387;
        bool bazar = true;
        int i = 1;

        int turno = 0;
        bool movExtra = false;
        PictureBox selecionado = null;

        List<PictureBox> azuis = new List<PictureBox>();
        List<PictureBox> vermel = new List<PictureBox>();
        bool morr;
        bool mortos_aparecem = false;

        public Form1()
        {
            InitializeComponent();
            CarregarListas();
        }

        

        //FORM PRINCIPAL QUE DECIDE QUEM FICA VISIVEL E QUEM NAO...
        private void Form1_Load(object sender, EventArgs e)
        {
            comidas();

            ponteiro1.Visible = false;
            ponteiro2.Visible = false;

            pessaboster.Visible = true;
            pessaCuca.Visible = true;
            pessasEKA.Visible = true;
            pessasSprit.Visible = true;


            menul.Visible = false;
            CLICKaudio.Visible = false;
            CLICKpersonalizar.Visible = false;
            CLICKPlay.Visible = false;
            CLICKopcoes.Visible = false;

            Regras.Visible = false;

           Regras.Size = new Size(703, 496); ;
           Regras.Location = new Point(176, 22);

            iniciar.Visible = true;
            iniciar.BringToFront();


            //ORGANIZACAO DO MENU COM CODIGOS AF3 

            TABULEIRO.Size = new Size(703, 496);
            iniciar.Size = new Size(703, 496);

            menul.Visible = true;
            menul.Size=new Size(largura,altura);
            menul.Location = new Point(176, 22);
            ClicadoPlay.Size = new Size(largura, altura);
            ClicadoPlay.Location = new Point(176, 22);
            CLICKaudio.Size = new Size(largura, altura);
            CLICKaudio.Location = new Point(176, 22);
            CLICKopcoes.Size = new Size(largura, altura);
            CLICKopcoes.Location = new Point(176, 22);
            CLICKpersonalizar.Size = new Size(largura, altura);
            CLICKpersonalizar.Location = new Point(176, 22);
            CLICKPlay.Size = new Size(largura, altura);
            CLICKPlay.Location = new Point(176, 22);
            TABULEIRO.Visible = false;
    
        }
        //botao para chamar panel do PLAY...
        private void btnPlay_Click(object sender, EventArgs e)
        {
            somBotao();
            CLICKPlay.Width = largura;
          CLICKPlay.Height = altura;

            CLICKPlay.Visible = true;
    
        }
        //botao para sair da panel PLAY...
        private void btnVoltar_Play_Click(object sender, EventArgs e)
        {
            somBotao();
            menul.Visible = true;
            CLICKPlay.Visible = false;
        }
        //Botao para chamar a panel DAS OPCOES...
        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            somBotao();
            menul.Visible = false;
            CLICKaudio.Visible = false;
            CLICKopcoes.Visible = true;
            CLICKopcoes.Width = largura;
            CLICKopcoes.Height = altura;
        }
        //botao para sair da panel Opcoes...
        private void btnVoltar_opcoes_Click_2(object sender, EventArgs e)
        {
            somBotao();
            menul.Visible = true;
            CLICKopcoes.Visible = false;
        }
        private void btnVoltar_opcoes_Click_1(object sender, EventArgs e)
        {

            menul.Visible = true;
            CLICKopcoes.Visible = false;
       }
        //botao que chamar a panel PERSONALIZAR... 
        private void btnpersonalizar_Click(object sender, EventArgs e)
        {
            CLICKaudio.Visible = false;
            CLICKpersonalizar.Visible = true;
            CLICKpersonalizar.Width = largura;
            CLICKpersonalizar.Height = altura;
            somBotao();

        }
        //botao para confirmar o primeiro nome...
        private void ConfirmName_Click(object sender, EventArgs e)
        {
            jogador1.Text = txtNome1.Text;
            txtNome1.Text = " ";
        }
        //botao para confirmar o nome...
        private void confirmaNome2_Click(object sender, EventArgs e)
        {
            jogador2.Text = txtnome2.Text;
            txtnome2.Text = " ";
        }
        //botao para sair da panel PERSONALIZAR...
        private void voltar_Personalizacao_Click(object sender, EventArgs e)
        {
            CLICKpersonalizar.Visible = false;
            somBotao();
        
        }
        //botao que Chamar a panel AUDIO....
        private void btnAudio_Click(object sender, EventArgs e)
        {
            menul.Visible = false;
            CLICKaudio.Width = largura;
            CLICKaudio.Height = altura;
            CLICKaudio.Visible = true;

    }
        //botap para sair da Panel audio...
        private void voltarAudio_Click(object sender, EventArgs e)
        {
            somBotao();
            menul.Visible = false;
            CLICKaudio.Visible = false;
    }
        //panel......PAiNT..................................
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        //METODO PARA O HOVER...
        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
           btnPlay.BackgroundImage = Properties.Resources.to;

        }
        //METODO PARA O HOVER...
        private void btnOpcoes_MouseMove(object sender, MouseEventArgs e)
        {
           btnOpcoes.BackgroundImage = Properties.Resources.to;
        }
        //METODO PARA O HOVERN do FORM...
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //botoes..........
            btnOpcoes.BackgroundImage = Properties.Resources.btover;
            btnPlay.BackgroundImage = Properties.Resources.btover;

            btnVoltar_Play.BackgroundImage = Properties.Resources.Voltar;
            btnVoltar_opcoes.BackgroundImage = Properties.Resources.Voltar;


            play_GAMEPC.BackgroundImage = Properties.Resources.N2;

            


            voltarAudio.BackgroundImage = Properties.Resources.Voltar;

            voltar_Personalizacao .BackgroundImage = Properties.Resources.Voltar;

            play_GAMEPC.BackgroundImage = Properties.Resources.btover;
            
            btnAudio.BackgroundImage = Properties.Resources.btover;
            btnpersonalizar.BackgroundImage = Properties.Resources.btover;
            

        }
        //METODO PARA O HOVER...
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            btnOpcoes.BackgroundImage = Properties.Resources.btover;
            btnPlay.BackgroundImage = Properties.Resources.btover;
        }



        //////////////////////////////////////////////////////////
        ///////////////////SOM SOM SOM SOM SOM////////////////////
        //////////////////////////////////////////////////////////

        //METODO PARA SONORO(para o som dos botao)...
        private void somBotao()
        {
            if (ativarSom.Checked == true) {
                ativarSom.Text = "Desativar";
            System.Media.SoundPlayer play = new System.Media.SoundPlayer(Properties.Resources.Bum5);
            play.Play();
            }
            else
            {
                ativarSom.Text = "Ativar";
            }
        }
        //METODO PARA SONORO(para o som dos movimento)...
        private void sommovimento()
        {
            if (ativarSom.Checked == true)
            {
                ativarSom.Text = "Desativar";
                System.Media.SoundPlayer play = new System.Media.SoundPlayer(Properties.Resources.movimento_das_pessas);
            play.Play();
            }
            else
            {
                ativarSom.Text = "Ativar";
            }
        }
        //METODO PARA SONORO(para o som das pessas comidas)...
        private void somComida()
        {
            if (ativarSom.Checked == true)
            {
                ativarSom.Text = "Desativar";

                System.Media.SoundPlayer play = new System.Media.SoundPlayer(Properties.Resources.comer);
            play.Play();
            }
            else
            {
                ativarSom.Text = "Ativar";
            }
        }

        //////////////////////////////////////////////////////////
        ///////FIM SOM FIM SOM FIM SOM FIM SOM////////////////////
        //////////////////////////////////////////////////////////



        //METODO para o HOVER...
        private void btnAudio_MouseMove(object sender, MouseEventArgs e)
        {


            btnAudio.BackgroundImage = Properties.Resources.to;

        }
        //METODO para o HOVER...
        private void play_GAMEPC_MouseMove(object sender, MouseEventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.N;
        }
        //METODO para o HOVER...
        private void btnVoltar_Play_MouseMove(object sender, MouseEventArgs e)
        {

            btnVoltar_Play.BackgroundImage = Properties.Resources.Voltar;
        }
        //METODO para o HOVER...
        private void play_GAMEPC_MouseMove_2(object sender, MouseEventArgs e)
        {
                play_GAMEPC.BackgroundImage = Properties.Resources.N;
        


        }
        //METODO para o HOVER...
        private void voltar_Personalizacao_MouseMove(object sender, MouseEventArgs e)
        {

            voltar_Personalizacao.BackgroundImage = Properties.Resources.voltarOver;
        }
        //METODO para o HOVER...
        private void voltarAudio_MouseMove(object sender, MouseEventArgs e)
        {
           voltarAudio.BackgroundImage = Properties.Resources.voltarOver;

        }      
        //botao para sair do jogo...
        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            somBotao();
        }
        //METODO para o HOVER...
        private void btnpersonalizar_MouseMove(object sender, MouseEventArgs e)
        {

            btnAudio.BackgroundImage = Properties.Resources.to;
        }
        //METODO para o HOVER...
        private void btnVoltar_opcoes_MouseHover(object sender, EventArgs e)
        {

            btnVoltar_opcoes.BackgroundImage = Properties.Resources.voltarOver;
        }
        //botao que chama a panel REGRAS
        private void play_GAMEPC_Click_1(object sender, EventArgs e)
        {
            CLICKPlay.Visible = false;
            Regras.Visible = true;
            somBotao();                         
        }

        //Metodo para deixar a panel de selecao invisivel...
        private void BACKGAME_Click(object sender, EventArgs e)
        {
            ClicadoPlay.Visible = false;
            Regras.Visible = true;
            somBotao();
        }
        
        //Metodo para chama a panel do tabuleiro...
        private void GOGAME_Click(object sender, EventArgs e)
        {
            CLICKPlay.Visible = false;
            somBotao();
            ClicadoPlay.Visible = false;
            TABULEIRO.Visible = true;
        }

        //Metodo do tempo que a progressBausa...
        private void Time(object sender, EventArgs e)
        {

            carregar.Value+=10;

            if (carregar.Value >= 100)
            {
                carregar.Value =90;
                iniciar.Visible = false;
            }



        }

        //Metodo para carregar a lista das pessas...
        private void CarregarListas()
        {
            azuis.Add(azul1);
            azuis.Add(azul2);
            azuis.Add(azul3);
            azuis.Add(azul4);
            azuis.Add(azul5);
            azuis.Add(azul6);
            azuis.Add(azul7);
            azuis.Add(azul8);
            azuis.Add(azul9);
            azuis.Add(azul10);
            azuis.Add(azul11);
            azuis.Add(azul12);


            vermel.Add(verm1);
            vermel.Add(verm3);
            vermel.Add(verm3);
            vermel.Add(verm4);
            vermel.Add(verm6);
            vermel.Add(verm6);
            vermel.Add(verm7);
            vermel.Add(verm9);
            vermel.Add(verm9);
            vermel.Add(verm10);
            vermel.Add(verm11);
            vermel.Add(verm12);


        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // //FUNCOES ADICIONAIS/ // // // // // // // // // // // // //
        // // // // // // // // // // ///////////// // // // /// // // // // // // // // // // //

        //Metodo para deixar as peças visiveis...
        public void pessasVisiveis()
        {
            morr = true;
            comidas();
            azul1.Visible = true;
            azul2.Visible = true;
            azul3.Visible = true;
            azul4.Visible = true;
            azul5.Visible = true;
            azul6.Visible = true;
            azul7.Visible = true;
            azul8.Visible = true;
            azul9.Visible = true;
            azul10.Visible = true;
            azul11.Visible = true;
            azul12.Visible = true;
            verm1.Visible = true;
            verm2.Visible = true;
            verm3.Visible = true;
            verm4.Visible = true;
            verm5.Visible = true;
            verm6.Visible = true;
            verm7.Visible = true;
            verm8.Visible = true;
            verm9.Visible = true;
            verm10.Visible = true;
            verm11.Visible = true;
            verm12.Visible = true;

        }
        //METODO para deixar a Zona das pessas comidas nao visiveis...
        public void comidas()
        {
            x1.Visible = false;
            x2.Visible = false;
            x3.Visible = false;
            x4.Visible = false;
            x5.Visible = false;
            x6.Visible = false;
            x7.Visible = false;
            x8.Visible = false;
            x9.Visible = false;
            x10.Visible = false;
            x11.Visible = false;
            x12.Visible = false;
            m1.Visible = false;
            m2.Visible = false;
            m3.Visible = false;
            m4.Visible = false;
            m5.Visible = false;
            m6.Visible = false;
            m7.Visible = false;
            m8.Visible = false;
            m9.Visible = false;
            m10.Visible = false;
            m11.Visible = false;
            m12.Visible = false;
        }

        //Metodo para a reposicao das pessas...
        public void localizacao()
        {
            azul1.Location = new Point(1, 101);
            azul2.Location = new Point(99, 100);
            azul3.Location = new Point(199, 100);
            azul4.Location = new Point(297, 100);
            azul5.Location = new Point(49, 50);
            azul6.Location = new Point(149, 50);
            azul7.Location = new Point(248, 50);
            azul8.Location = new Point(346, 50);
            azul9.Location = new Point(1, 1);
            azul10.Location = new Point(99, 0);
            azul11.Location = new Point(198, 0);
            azul12.Location = new Point(296, 0);
            verm1.Location = new Point(50, 250);
            verm2.Location = new Point(248, 250);
            verm3.Location = new Point(149, 250);
            verm4.Location = new Point(345, 250);
            verm5.Location = new Point(51, 350);

            verm6.Location = new Point(2, 300);
            verm7.Location = new Point(100, 300);
            verm8.Location = new Point(199, 300);
            verm9.Location = new Point(297, 300);
            verm10.Location = new Point(151, 350);
            verm11.Location = new Point(250, 350);
            verm12.Location = new Point(348, 350);
        }
        ////////////////////////////////////////////////////////////////////////////////////////














        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // /TAbulEiro // // // // /// // // // // // // // // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

        public void selecao(object objeto)
        {
            if (!movExtra)
            {
                try { selecionado.BackColor = Color.Black; }
                catch { }
                PictureBox ficha = (PictureBox)objeto;
                selecionado = ficha;
                selecionado.BackColor = Color.LightGray;
            }
        }

        private void QuadroClick(object sender, MouseEventArgs e)
        {
            Movimento((PictureBox)sender);
        }

        private void Movimento(PictureBox Quadro)
        {

            if (selecionado != null)
            {
                string color = selecionado.Name.ToString().Substring(0, 4);

                if (validacao(selecionado, Quadro, color))//Validação...
                {

                    Point anterior = selecionado.Location;
                    selecionado.Location = Quadro.Location;
                    int avance = anterior.Y - Quadro.Location.Y;

                    if (!movimentoExtras(color) || Math.Abs(avance) == 50)//Verificar Movimentos(Comidas) Extras
                    {
                        seDama(color);
                        turno++;
                        selecionado.BackColor = Color.Black;
                        selecionado = null;
                        movExtra = false;
                    }
                    else
                    {
                        movExtra = true;

                    }
                }
            }
        }

        private bool movimentoExtras(string color)
        {

            List<PictureBox> bandoazuis = color == "azul" ? azuis : azuis;
            List<PictureBox> bandovermelo = color == "verm" ? vermel : vermel;
            List<Point> posicoes = new List<Point>();

            int vermPosicao = color == "verm" ? 100 : 100;
            int azulposicao = color == "azul" ? -100 : -100;

            posicoes.Add(new Point(selecionado.Location.X + 100, selecionado.Location.Y - vermPosicao));
            posicoes.Add(new Point(selecionado.Location.X - 100, selecionado.Location.Y - azulposicao));


            if (selecionado.Tag == "queen")
            {
                posicoes.Add(new Point(selecionado.Location.X + 100, selecionado.Location.Y - vermPosicao));
                posicoes.Add(new Point(selecionado.Location.X - 100, selecionado.Location.Y - azulposicao));
            }



            bool resultado = false;
            for (int i = 0; i < posicoes.Count; i++)
            {
                if (posicoes[i].X >= 50 && posicoes[i].X <= 400 && posicoes[i].Y >= 50 && posicoes[i].Y <= 400)
                {
                    if (!ocupado(posicoes[i], vermel) && !ocupado(posicoes[i], azuis))
                    {
                        Point pontoMedio = new Point(promedio(posicoes[i].X, selecionado.Location.X), promedio(posicoes[i].Y, selecionado.Location.Y));
                        if (ocupado(pontoMedio, bandovermelo))
                        {
                            resultado = true;
                        }
                        if (ocupado(pontoMedio, bandoazuis))
                        {
                            resultado = true;
                        }
                    }
                }
            }



            return resultado;
        }




        private bool ocupado(Point ponto, List<PictureBox> bando)
        {
            for (int i = 0; i < bando.Count; i++)
            {
                if (ponto == bando[i].Location)
                {
                    return true;
                }
            }




            return false;
        }


        private int promedio(int n1, int n2)
        {
            int resultado = n1 + n2;
            resultado = resultado / 2;
            return Math.Abs(resultado);

        }

        int p1, p2;
        int morto=0,mortoA=0;

        private bool validacao(PictureBox origem, PictureBox destino, string color)
        {

            sommovimento();
            Point pontoOrigem = origem.Location;
            Point pontoDestino = destino.Location;
            int avance = pontoOrigem.Y - pontoDestino.Y;

            avance = color == "verm" ? avance : (avance * -1);
            avance = color == "azul" ? avance : (avance * 1);
     
                avance = selecionado.Tag == "queen" ? Math.Abs(avance) : avance;
            


            if (avance == 50)
            {
                return true;
            }
            else if (avance == 100)
            {
                Point pontoMedio = new Point(promedio(pontoDestino.X, pontoOrigem.X), promedio(pontoDestino.Y, pontoOrigem.Y));
                List<PictureBox> bandovermelo = color == "verm" ? vermel : vermel;
                List<PictureBox> bandoazul = color == "azul" ? azuis : azuis;
                for (int i = 0; i < bandovermelo.Count; i++)
                {
                    if (bandovermelo[i].Location == pontoMedio)
                    {

                        ponteiro1.Visible = true;
                        ponteiro2.Visible =false;
                        somComida();
                        p1++;
                        ponto2.Text = Convert.ToString(p1);
                        bandovermelo[i].Location = new Point(0, 0);                     
                        bandovermelo[i].Visible = false;

                        if (morr == true)
                        {
                            comidas();
                        }
                        
                        morto++;
                        if  (morto==1) { x1.Visible = true; }
                        if (morto == 2) { x2.Visible = true; }
                        if (morto == 3) { x3.Visible = true; }
                        if (morto == 4) { x4.Visible = true; }
                        if (morto == 5) { x5.Visible = true; }
                        if (morto == 6) { x6.Visible = true; }
                        if (morto == 7) { x7.Visible = true; }
                        if (morto == 8) { x8.Visible = true; }
                        if (morto == 9) { x9.Visible = true; }
                        if (morto == 10) { x10.Visible = true; }
                        if (morto == 11) { x11.Visible = true; }
                        if (morto == 12) { x12.Visible = true; }
                        
                        return true;
                    }
                }

                for (int i = 0; i < bandoazul.Count; i++)
                {

                    if (bandoazul[i].Location == pontoMedio)
                    {
                        mortos_aparecem = false;
                        if (mortos_aparecem==false) { 
                        p2++;

                            somComida();

                        ponto1.Text = Convert.ToString(p2);
                        bandoazul[i].Location = new Point(0, 0);
                        bandoazul[i].Visible = false;

                        mortoA++;

                        if (mortoA == 1) { m1.Visible = true; }
                        if (mortoA == 2) { m2.Visible = true; }
                        if (mortoA == 3) { m3.Visible = true; }
                        if (mortoA == 4) { m4.Visible = true; }
                        if (mortoA == 5) { m5.Visible = true; }
                        if (mortoA == 6) { m6.Visible = true; }
                        if (mortoA == 7) { m7.Visible = true; }
                        if (mortoA == 8) { m8.Visible = true; }
                        if (mortoA == 9) { m9.Visible = true; }
                        if (mortoA == 10) { m10.Visible = true; }
                        if (mortoA == 11) { m11.Visible = true; }
                        if (mortoA == 12) { m12.Visible = true; }
}
 
                        return true;
                    }
                }
            }
            return false;
        }






        //Metodo para determinar quando um peao se torna DAma...
        private void seDama(string color)
        {  
            if (color == "azul" && selecionado.Location.Y == 350)
            {
               selecionado.Image = Properties.Resources.blue;
                selecionado.Tag = "queen";
            }

            else if (color == "verm" && selecionado.Location.Y ==0)
            {
               selecionado.Image = Properties.Resources.pngwing_com__8_;
                selecionado.Tag = "queen";
            }
        }

        private void selecaoVerm(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 1)
            {
                ponteiro2.Visible = true;
                ponteiro1.Visible = false;

                selecao(sender);
            }

            else
            {
            
            }
        }

        private void selecaoAzul(object sender, MouseEventArgs e)
        {
            if (turno % 2 == 0)
            {
                ponteiro2.Visible = false;
                ponteiro1.Visible = true;
                selecao(sender);
            }
            else
            {
            }
        }

        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // ////////////// / FIM DA CODIFICACAO DO TABULEIRO TAbulEiro // // // // /// // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
















        //tela inicial isto e onde esta o progresbar
        private void iniciar_Paint(object sender, PaintEventArgs e)
        {
            ClicadoPlay.Visible = false;
        }

        //Metodo de escolha do avatar padrao...
        private void pess1a_Click(object sender, EventArgs e)
        {

           pess1a.Enabled = false;
            Amostra.Image = Properties.Resources.pngwing_com__8_;
            
           A1.Enabled = false;

            pessa2.Enabled = true;
            pessa3.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;
            


            azul1.Image = Properties.Resources.pngwing_com__8_;
            azul2.Image = Properties.Resources.pngwing_com__8_;
            azul3.Image = Properties.Resources.pngwing_com__8_;
            azul4.Image = Properties.Resources.pngwing_com__8_;
            azul5.Image = Properties.Resources.pngwing_com__8_;
            azul6.Image = Properties.Resources.pngwing_com__8_;
            azul7.Image = Properties.Resources.pngwing_com__8_;
            azul8.Image = Properties.Resources.pngwing_com__8_;
            azul9.Image = Properties.Resources.pngwing_com__8_;
            azul10.Image = Properties.Resources.pngwing_com__8_;
            azul11.Image = Properties.Resources.pngwing_com__8_;
            azul12.Image = Properties.Resources.pngwing_com__8_;

            x1.Image = Properties.Resources.pngwing_com__8_;
            x2.Image = Properties.Resources.pngwing_com__8_;
            x3.Image = Properties.Resources.pngwing_com__8_;
            x4.Image = Properties.Resources.pngwing_com__8_;
            x5.Image = Properties.Resources.pngwing_com__8_;
            x6.Image = Properties.Resources.pngwing_com__8_;
            x7.Image = Properties.Resources.pngwing_com__8_;
            x8.Image = Properties.Resources.pngwing_com__8_;
            x9.Image = Properties.Resources.pngwing_com__8_;
            x10.Image = Properties.Resources.pngwing_com__8_;
            x11.Image = Properties.Resources.pngwing_com__8_;
            x12.Image = Properties.Resources.pngwing_com__8_;

        }

        //Metodo de escolha do avatar C#...
        private void pessa2_Click(object sender, EventArgs e)
        {
           
            Amostra.Image = Properties.Resources.booster;
            pessa2.Enabled = false; A2.Enabled = false;
            pess1a.Enabled = true;
            pessa3.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;


            azul1.Image = Properties.Resources.booster;
            azul2.Image = Properties.Resources.booster;
            azul3.Image = Properties.Resources.booster;
            azul4.Image = Properties.Resources.booster;
            azul5.Image = Properties.Resources.booster;
            azul6.Image = Properties.Resources.booster;
            azul7.Image = Properties.Resources.booster;
            azul8.Image = Properties.Resources.booster;
            azul9.Image = Properties.Resources.booster;
            azul10.Image = Properties.Resources.booster;
            azul11.Image = Properties.Resources.booster;
            azul12.Image = Properties.Resources.booster;

            x1.Image = Properties.Resources.booster;
            x2.Image = Properties.Resources.booster;
            x3.Image = Properties.Resources.booster;
            x4.Image = Properties.Resources.booster;
            x5.Image = Properties.Resources.booster;
            x6.Image = Properties.Resources.booster;
            x7.Image = Properties.Resources.booster;
            x8.Image = Properties.Resources.booster;
            x9.Image = Properties.Resources.booster;
            x10.Image = Properties.Resources.booster;
            x11.Image = Properties.Resources.booster;
            x12.Image = Properties.Resources.booster;

        }

        //Metodo de escolha do avatar dagosto...
        private void pessa3_Click(object sender, EventArgs e)
        {
         
            Amostra.Image = Properties.Resources.daosto;
            pessa3.Enabled = false;   A3.Enabled = false;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;

            x1.Image = Properties.Resources.daosto;
            x2.Image = Properties.Resources.daosto;
            x3.Image = Properties.Resources.daosto;
            x4.Image = Properties.Resources.daosto;
            x5.Image = Properties.Resources.daosto;
            x6.Image = Properties.Resources.daosto;
            x7.Image = Properties.Resources.daosto;
            x8.Image = Properties.Resources.daosto;
            x9.Image = Properties.Resources.daosto;
            x10.Image = Properties.Resources.daosto;
            x11.Image = Properties.Resources.daosto;
            x12.Image = Properties.Resources.daosto;

            azul1.Image = Properties.Resources.daosto;
            azul2.Image = Properties.Resources.daosto;
            azul3.Image = Properties.Resources.daosto;
            azul4.Image = Properties.Resources.daosto;
            azul5.Image = Properties.Resources.daosto;
            azul6.Image = Properties.Resources.daosto;
            azul7.Image = Properties.Resources.daosto;
            azul8.Image = Properties.Resources.daosto;
            azul9.Image = Properties.Resources.daosto;
            azul10.Image = Properties.Resources.daosto;
            azul11.Image = Properties.Resources.daosto;
            azul12.Image = Properties.Resources.daosto;
        }

        //Metodo de escolha do avatar petro...
        private void pessa4_Click(object sender, EventArgs e)
        {
           
            Amostra.Image = Properties.Resources.pétro;
            pessa3.Enabled = true; A4.Enabled = false;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = false;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;

            m1.Image = Properties.Resources.pétro;
            m2.Image = Properties.Resources.pétro;
            m3.Image = Properties.Resources.pétro;
            m4.Image = Properties.Resources.pétro;
            m5.Image = Properties.Resources.pétro;
            m6.Image = Properties.Resources.pétro;
            m7.Image = Properties.Resources.pétro;
            m8.Image = Properties.Resources.pétro;
            m9.Image = Properties.Resources.pétro;
            m10.Image = Properties.Resources.pétro;
            m11.Image = Properties.Resources.pétro;
            m12.Image = Properties.Resources.pétro;


            azul1.Image = Properties.Resources.pétro;
            azul2.Image = Properties.Resources.pétro;
            azul3.Image = Properties.Resources.pétro;
            azul4.Image = Properties.Resources.pétro;
            azul5.Image = Properties.Resources.pétro;
            azul6.Image = Properties.Resources.pétro;
            azul7.Image = Properties.Resources.pétro;
            azul8.Image = Properties.Resources.pétro;
            azul9.Image = Properties.Resources.pétro;
            azul10.Image = Properties.Resources.pétro;
            azul11.Image = Properties.Resources.pétro;
            azul12.Image = Properties.Resources.pétro;
        }

        //Metodo de escolha do avatar booster...
        private void pessaboster_Click(object sender, EventArgs e)
        {
        
            Amostra.Image = Properties.Resources.booster;
            A5.Enabled = false;
            pessa3.Enabled = true;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = false;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;
           



            azul1.Image = Properties.Resources.booster;
            azul2.Image = Properties.Resources.booster;
            azul3.Image = Properties.Resources.booster;
            azul4.Image = Properties.Resources.booster;
            azul5.Image = Properties.Resources.booster;
            azul6.Image = Properties.Resources.booster;
            azul7.Image = Properties.Resources.booster;
            azul8.Image = Properties.Resources.booster;
            azul9.Image = Properties.Resources.booster;
            azul10.Image = Properties.Resources.booster;
            azul11.Image = Properties.Resources.booster;
            azul12.Image = Properties.Resources.booster;

            m1.Image = Properties.Resources.booster;
            m2.Image = Properties.Resources.booster;
            m3.Image = Properties.Resources.booster;
            m4.Image = Properties.Resources.booster;
            m5.Image = Properties.Resources.booster;
            m6.Image = Properties.Resources.booster;
            m7.Image = Properties.Resources.booster;
            m8.Image = Properties.Resources.booster;
            m9.Image = Properties.Resources.booster;
            m10.Image = Properties.Resources.booster;
            m11.Image = Properties.Resources.booster;
            m12.Image = Properties.Resources.booster;

        }
      
        //Metodo de escolha do avatar cuca...
        private void pessaCuca_Click(object sender, EventArgs e)
        {
            
            Amostra.Image = Properties.Resources.cucaf;
            A6.Enabled = false;
            pessaCuca.Enabled = false;
            pessa3.Enabled = true;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = false;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled = true;

            m1.Image = Properties.Resources.cucaf;
            m2.Image = Properties.Resources.cucaf;
            m3.Image = Properties.Resources.cucaf;
            m4.Image = Properties.Resources.cucaf;
            m5.Image = Properties.Resources.cucaf;
            m6.Image = Properties.Resources.cucaf;
            m7.Image = Properties.Resources.cucaf;
            m8.Image = Properties.Resources.cucaf;
            m9.Image = Properties.Resources.cucaf;
            m10.Image = Properties.Resources.cucaf;
            m11.Image = Properties.Resources.cucaf;
            m12.Image = Properties.Resources.cucaf;

            azul1.Image = Properties.Resources.cucaf;
            azul2.Image = Properties.Resources.cucaf;
            azul3.Image = Properties.Resources.cucaf;
            azul4.Image = Properties.Resources.cucaf;
            azul5.Image = Properties.Resources.cucaf;
            azul6.Image = Properties.Resources.cucaf;
            azul7.Image = Properties.Resources.cucaf;
            azul8.Image = Properties.Resources.cucaf;
            azul9.Image = Properties.Resources.cucaf;
            azul10.Image = Properties.Resources.cucaf;
            azul11.Image = Properties.Resources.cucaf;
            azul12.Image = Properties.Resources.cucaf;
        }

        //Metodo de escolha do avatar EKA...
        private void pessasEKA_Click(object sender, EventArgs e)
        {
      Amostra.Image = Properties.Resources.Eka;
            pessasEKA.Enabled = false;
            A8.Enabled = false;
      
            pessa3.Enabled = true;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasSprit.Enabled = true;
            pessasEKA.Enabled = false;

            m1.Image = Properties.Resources.Eka;
            m2.Image = Properties.Resources.Eka;
            m3.Image = Properties.Resources.Eka;
            m4.Image = Properties.Resources.Eka;
            m5.Image = Properties.Resources.Eka;
            m6.Image = Properties.Resources.Eka;
            m7.Image = Properties.Resources.Eka;
            m8.Image = Properties.Resources.Eka;
            m9.Image = Properties.Resources.Eka;
            m10.Image = Properties.Resources.Eka;
            m11.Image = Properties.Resources.Eka;
            m12.Image = Properties.Resources.Eka;

            azul1.Image = Properties.Resources.Eka;
            azul2.Image = Properties.Resources.Eka;
            azul3.Image = Properties.Resources.Eka;
            azul4.Image = Properties.Resources.Eka;
            azul5.Image = Properties.Resources.Eka;
            azul6.Image = Properties.Resources.Eka;
            azul7.Image = Properties.Resources.Eka;
            azul8.Image = Properties.Resources.Eka;
            azul9.Image = Properties.Resources.Eka;
            azul10.Image = Properties.Resources.Eka;
            azul11.Image = Properties.Resources.Eka;
            azul12.Image = Properties.Resources.Eka;
        }

       
        
        //Metodo de escolha do avatar Sprite...
        private void pessasSprit_Click(object sender, EventArgs e)
        {
            
            Amostra.Image = Properties.Resources.nocal;
            pessa3.Enabled = true;A7.Enabled = false;
            pess1a.Enabled = true;
            pessa2.Enabled = true;
            pessa4.Enabled = true;
            pessaboster.Enabled = true;
            pessaCuca.Enabled = true;
            pessasEKA.Enabled = true;
            pessasSprit.Enabled =false;


            m1.Image = Properties.Resources.nocal;
            m2.Image = Properties.Resources.nocal;
            m3.Image = Properties.Resources.nocal;
            m4.Image = Properties.Resources.nocal;
            m5.Image = Properties.Resources.nocal;
            m6.Image = Properties.Resources.nocal;
            m7.Image = Properties.Resources.nocal;
            m8.Image = Properties.Resources.nocal;
            m9.Image = Properties.Resources.nocal;
            m10.Image = Properties.Resources.nocal;
            m11.Image = Properties.Resources.nocal;
            m12.Image = Properties.Resources.nocal;

            azul1.Image = Properties.Resources.nocal;
            azul2.Image = Properties.Resources.nocal;
            azul3.Image = Properties.Resources.nocal;
            azul4.Image = Properties.Resources.nocal;
            azul5.Image = Properties.Resources.nocal;
            azul6.Image = Properties.Resources.nocal;
            azul7.Image = Properties.Resources.nocal;
            azul8.Image = Properties.Resources.nocal;
            azul9.Image = Properties.Resources.nocal;
            azul10.Image = Properties.Resources.nocal;
            azul11.Image = Properties.Resources.nocal;
            azul12.Image = Properties.Resources.nocal;
        }

        //botao da regra internacional...
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção não disponivel");
        }

        //botao da regra inglesa...
        private void RingraIng_Click(object sender, EventArgs e)
        {
            Regras.Visible = false;
            ClicadoPlay.Visible = true;
        }

        //botao da regra italiana...
        private void Rfrancesa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção não disponivel");
        }

        //botao para sair a panel das regras 
        private void button5_Click(object sender, EventArgs e)
        {
            CLICKPlay.Visible = true;
            Regras.Visible = false;
        }



        private void A1_Click(object sender, EventArgs e)
        {
        
            Amostra2.Image = Properties.Resources.pngwing_com__8_;
            pess1a.Enabled = false;
            x1.Image = Properties.Resources.pngwing_com__8_;
            x2.Image = Properties.Resources.pngwing_com__8_;
            x3.Image = Properties.Resources.pngwing_com__8_;
            x4.Image = Properties.Resources.pngwing_com__8_;
            x5.Image = Properties.Resources.pngwing_com__8_;
            x6.Image = Properties.Resources.pngwing_com__8_;
            x7.Image = Properties.Resources.pngwing_com__8_;
            x8.Image = Properties.Resources.pngwing_com__8_;
            x9.Image = Properties.Resources.pngwing_com__8_;
            x10.Image = Properties.Resources.pngwing_com__8_;
            x11.Image = Properties.Resources.pngwing_com__8_;
            x12.Image = Properties.Resources.pngwing_com__8_;


            verm1.Image = Properties.Resources.pngwing_com__8_;
            verm2.Image = Properties.Resources.pngwing_com__8_;
            verm3.Image = Properties.Resources.pngwing_com__8_;
            verm4.Image = Properties.Resources.pngwing_com__8_;
            verm5.Image = Properties.Resources.pngwing_com__8_;
            verm6.Image = Properties.Resources.pngwing_com__8_;
            verm7.Image = Properties.Resources.pngwing_com__8_;
            verm8.Image = Properties.Resources.pngwing_com__8_;
            verm9.Image = Properties.Resources.pngwing_com__8_;
            verm10.Image = Properties.Resources.pngwing_com__8_;
            verm11.Image = Properties.Resources.pngwing_com__8_;
            verm12.Image = Properties.Resources.pngwing_com__8_;
        }

        private void A2_Click(object sender, EventArgs e)
        {
           
            Amostra2.Image = Properties.Resources.qw;
            pessa2.Enabled = false;
            x1.Image = Properties.Resources.qw;
            x2.Image = Properties.Resources.qw;
            x3.Image = Properties.Resources.qw;
            x4.Image = Properties.Resources.qw;
            x5.Image = Properties.Resources.qw;
            x6.Image = Properties.Resources.qw;
            x7.Image = Properties.Resources.qw;
            x8.Image = Properties.Resources.qw;
            x9.Image = Properties.Resources.qw;
            x10.Image = Properties.Resources.qw;
            x11.Image = Properties.Resources.qw;
            x12.Image = Properties.Resources.qw;

            verm1.Image = Properties.Resources.qw;
            verm2.Image = Properties.Resources.qw;
            verm3.Image = Properties.Resources.qw;
            verm4.Image = Properties.Resources.qw;
            verm5.Image = Properties.Resources.qw;
            verm6.Image = Properties.Resources.qw;
            verm7.Image = Properties.Resources.qw;
            verm8.Image = Properties.Resources.qw;
            verm9.Image = Properties.Resources.qw;
            verm10.Image = Properties.Resources.qw;
            verm11.Image = Properties.Resources.qw;
            verm12.Image = Properties.Resources.qw;
        }

        private void A3_Click(object sender, EventArgs e)
        {
            
            Amostra2.Image = Properties.Resources.daosto;
            pessa3.Enabled = false;
            x1.Image = Properties.Resources.daosto;
            x2.Image = Properties.Resources.daosto;
            x3.Image = Properties.Resources.daosto;
            x4.Image = Properties.Resources.daosto;
            x5.Image = Properties.Resources.daosto;
            x6.Image = Properties.Resources.daosto;
            x7.Image = Properties.Resources.daosto;
            x8.Image = Properties.Resources.daosto;
            x9.Image = Properties.Resources.daosto;
            x10.Image = Properties.Resources.daosto;
            x11.Image = Properties.Resources.daosto;
            x12.Image = Properties.Resources.daosto;

            verm1.Image = Properties.Resources.daosto;
            verm2.Image = Properties.Resources.daosto;
            verm3.Image = Properties.Resources.daosto;
            verm4.Image = Properties.Resources.daosto;
            verm5.Image = Properties.Resources.daosto;
            verm6.Image = Properties.Resources.daosto;
            verm7.Image = Properties.Resources.daosto;
            verm8.Image = Properties.Resources.daosto;
            verm9.Image = Properties.Resources.daosto;
            verm10.Image = Properties.Resources.daosto;
            verm11.Image = Properties.Resources.daosto;
            verm12.Image = Properties.Resources.daosto;
        }

        private void A4_Click(object sender, EventArgs e)
        {
           
            Amostra2.Image = Properties.Resources.pétro;
            pessa4.Enabled = false;
            x1.Image = Properties.Resources.pétro;
            x2.Image = Properties.Resources.pétro;
            x3.Image = Properties.Resources.pétro;
            x4.Image = Properties.Resources.pétro;
            x5.Image = Properties.Resources.pétro;
            x6.Image = Properties.Resources.pétro;
            x7.Image = Properties.Resources.pétro;
            x8.Image = Properties.Resources.pétro;
            x9.Image = Properties.Resources.pétro;
            x10.Image = Properties.Resources.pétro;
            x11.Image = Properties.Resources.pétro;
            x12.Image = Properties.Resources.pétro;

            verm1.Image = Properties.Resources.pétro;
            verm2.Image = Properties.Resources.pétro;
            verm3.Image = Properties.Resources.pétro;
            verm4.Image = Properties.Resources.pétro;
            verm5.Image = Properties.Resources.pétro;
            verm6.Image = Properties.Resources.pétro;
            verm7.Image = Properties.Resources.pétro;
            verm8.Image = Properties.Resources.pétro;
            verm9.Image = Properties.Resources.pétro;
            verm10.Image = Properties.Resources.pétro;
            verm11.Image = Properties.Resources.pétro;
            verm12.Image = Properties.Resources.pétro;
        }

        private void A5_Click(object sender, EventArgs e)
        {
           
            Amostra2.Image = Properties.Resources.booster;
            pessaboster.Enabled = false;
            x1.Image = Properties.Resources.booster;
            x2.Image = Properties.Resources.booster;
            x3.Image = Properties.Resources.booster;
            x4.Image = Properties.Resources.booster;
            x5.Image = Properties.Resources.booster;
            x6.Image = Properties.Resources.booster;
            x7.Image = Properties.Resources.booster;
            x8.Image = Properties.Resources.booster;
            x9.Image = Properties.Resources.booster;
            x10.Image = Properties.Resources.booster;
            x11.Image = Properties.Resources.booster;
            x12.Image = Properties.Resources.booster;

            verm1.Image = Properties.Resources.booster;
            verm2.Image = Properties.Resources.booster;
            verm3.Image = Properties.Resources.booster;
            verm4.Image = Properties.Resources.booster;
            verm5.Image = Properties.Resources.booster;
            verm6.Image = Properties.Resources.booster;
            verm7.Image = Properties.Resources.booster;
            verm8.Image = Properties.Resources.booster;
            verm9.Image = Properties.Resources.booster;
            verm10.Image = Properties.Resources.booster;
            verm11.Image = Properties.Resources.booster;
            verm12.Image = Properties.Resources.booster;
        }

        private void A6_Click(object sender, EventArgs e)
        {
           
            Amostra2.Image = Properties.Resources.cucaf;
            pessaCuca.Enabled = false;
            x1.Image = Properties.Resources.cucaf;
            x2.Image = Properties.Resources.cucaf;
            x3.Image = Properties.Resources.cucaf;
            x4.Image = Properties.Resources.cucaf;
            x5.Image = Properties.Resources.cucaf;
            x6.Image = Properties.Resources.cucaf;
            x7.Image = Properties.Resources.cucaf;
            x8.Image = Properties.Resources.cucaf;
            x9.Image = Properties.Resources.cucaf;
            x10.Image = Properties.Resources.cucaf;
            x11.Image = Properties.Resources.cucaf;
            x12.Image = Properties.Resources.cucaf;

            verm1.Image = Properties.Resources.cucaf;
            verm2.Image = Properties.Resources.cucaf;
            verm3.Image = Properties.Resources.cucaf;
            verm4.Image = Properties.Resources.cucaf;
            verm5.Image = Properties.Resources.cucaf;
            verm6.Image = Properties.Resources.cucaf;
            verm7.Image = Properties.Resources.cucaf;
            verm8.Image = Properties.Resources.cucaf;
            verm9.Image = Properties.Resources.cucaf;
            verm10.Image = Properties.Resources.cucaf;
            verm11.Image = Properties.Resources.cucaf;
            verm12.Image = Properties.Resources.cucaf;
        }

        private void A7_Click(object sender, EventArgs e)
        {
            
            Amostra2.Image = Properties.Resources.sprite;
            pessasSprit.Enabled = false;
            x1.Image = Properties.Resources.sprite;
            x2.Image = Properties.Resources.sprite;
            x3.Image = Properties.Resources.sprite;
            x4.Image = Properties.Resources.sprite;
            x5.Image = Properties.Resources.sprite;
            x6.Image = Properties.Resources.sprite;
            x7.Image = Properties.Resources.sprite;
            x8.Image = Properties.Resources.sprite;
            x9.Image = Properties.Resources.sprite;
            x10.Image = Properties.Resources.sprite;
            x11.Image = Properties.Resources.sprite;
            x12.Image = Properties.Resources.sprite;

            verm1.Image = Properties.Resources.sprite;
            verm2.Image = Properties.Resources.sprite;
            verm3.Image = Properties.Resources.sprite;
            verm4.Image = Properties.Resources.sprite;
            verm5.Image = Properties.Resources.sprite;
            verm6.Image = Properties.Resources.sprite;
            verm7.Image = Properties.Resources.sprite;
            verm8.Image = Properties.Resources.sprite;
            verm9.Image = Properties.Resources.sprite;
            verm10.Image = Properties.Resources.sprite;
            verm11.Image = Properties.Resources.sprite;
            verm12.Image = Properties.Resources.sprite;
        }

        private void A8_Click(object sender, EventArgs e)
        {
            
            Amostra2.Image = Properties.Resources.Eka;
            pessasEKA.Enabled = false;
            x1.Image = Properties.Resources.Eka;
            x2.Image = Properties.Resources.Eka;
            x3.Image = Properties.Resources.Eka;
            x4.Image = Properties.Resources.Eka;
            x5.Image = Properties.Resources.Eka;
            x6.Image = Properties.Resources.Eka;
            x7.Image = Properties.Resources.Eka;
            x8.Image = Properties.Resources.Eka;
            x9.Image = Properties.Resources.Eka;
            x10.Image = Properties.Resources.Eka;
            x11.Image = Properties.Resources.Eka;
            x12.Image = Properties.Resources.Eka;

            verm1.Image = Properties.Resources.Eka;
            verm2.Image = Properties.Resources.Eka;
            verm3.Image = Properties.Resources.Eka;
            verm4.Image = Properties.Resources.Eka;
            verm5.Image = Properties.Resources.Eka;
            verm6.Image = Properties.Resources.Eka;
            verm7.Image = Properties.Resources.Eka;
            verm8.Image = Properties.Resources.Eka;
            verm9.Image = Properties.Resources.Eka;
            verm10.Image = Properties.Resources.Eka;
            verm11.Image = Properties.Resources.Eka;
            verm12.Image = Properties.Resources.Eka;
        }

        //botao para sair do tabuleiro...
        private void sairTABULEIRO_Click(object sender, EventArgs e)
        {


            TABULEIRO.Visible = false;
            ClicadoPlay.Visible = true;
            comidas();
            localizacao();
            pessasVisiveis();

        }

        //Metodo de repeticao do jogo...
        private void Repetir_Click(object sender, EventArgs e)
        {
            morr = true;
            comidas();
            localizacao();
            pessasVisiveis();
            p1 = 0;
            p2 = 0;
            ponto1.Text = Convert.ToString(p1);
            ponto2.Text = Convert.ToString(p2);

        }

    }

}      













    

