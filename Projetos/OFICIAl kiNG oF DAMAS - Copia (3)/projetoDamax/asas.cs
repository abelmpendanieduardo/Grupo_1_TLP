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
    public partial class oTabuleiro :Form
    {
            int turno = 0;
            bool movExtra = false;
            PictureBox selecionado = null;

            List<PictureBox> azuis = new List<PictureBox>();
            List<PictureBox> vermel = new List<PictureBox>();
        public oTabuleiro()
        {
            InitializeComponent();
            CarregarListas();
        }


            private void CarregarListas()
            {
                azuis.Add(B1);
                azuis.Add(B2);
                azuis.Add(B3);
                azuis.Add(B4);
                azuis.Add(B5);
                azuis.Add(B6);
                azuis.Add(B7);
                azuis.Add(B8);
                azuis.Add(B9);
                azuis.Add(B3);
                azuis.Add(B2);
                azuis.Add(B1);


                vermel.Add(A1);
                vermel.Add(A2);
                vermel.Add(A3);
                vermel.Add(A4);
                vermel.Add(A6);
                vermel.Add(A6);
                vermel.Add(A7);
                vermel.Add(A8);
                vermel.Add(A9);
                vermel.Add(A10);
                vermel.Add(A11);
                vermel.Add(A12);


            }

            public void selecao(object objeto)
            {
                if (!movExtra)
                {
                //Metodo para fixar a pessa...
                    try { selecionado.BackColor = Color.Black; }
                    catch { }
                    PictureBox fixa = (PictureBox)objeto;
                    selecionado = fixa;
                    selecionado.BackColor = Color.DeepPink;
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

                        if (!movimentoExtras(color) | Math.Abs(avance) == 50)//Verificar Movimentos(Comidas) Extras
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

                List<PictureBox> bandoContraio = color == "verm" ? azuis : vermel;
                List<Point> posicoes = new List<Point>();
                int sigPosicao = color == "verm" ? -100 : 100;

                posicoes.Add(new Point(selecionado.Location.X + 100, selecionado.Location.Y + sigPosicao));
                posicoes.Add(new Point(selecionado.Location.X - 100, selecionado.Location.Y + sigPosicao));
                if (selecionado.Tag == "queen")
                {
                    posicoes.Add(new Point(selecionado.Location.X + 100, selecionado.Location.Y - sigPosicao));
                    posicoes.Add(new Point(selecionado.Location.X - 100, selecionado.Location.Y - sigPosicao));
                }

                bool resultado = false;
                for (int i = 0; i < posicoes.Count; i++)
                {
                    if (posicoes[i].X >= 50 && posicoes[i].X <= 400 && posicoes[i].Y >= 50 && posicoes[i].Y <= 400)
                    {
                        if (!ocupado(posicoes[i], vermel) && !ocupado(posicoes[i], azuis))
                        {
                            Point pontoMedio = new Point(promedio(posicoes[i].X, selecionado.Location.X), promedio(posicoes[i].Y, selecionado.Location.Y));
                            if (ocupado(pontoMedio, bandoContraio))
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

            private bool validacao(PictureBox origem, PictureBox destino, string color)
            {
                Point pontoOrigem = origem.Location;
                Point pontoDestino = destino.Location;
                int avance = pontoOrigem.Y - pontoDestino.Y;
                avance = color == "verm" ? avance : (avance * -1);
                avance = selecionado.Tag == "queen" ? Math.Abs(avance) : avance;
                if (avance == 50)
                {
                    return true;
                }
                else if (avance == 100)
                {
                    Point pontoMedio = new Point(promedio(pontoDestino.X, pontoOrigem.X), promedio(pontoDestino.Y, pontoOrigem.Y));
                    List<PictureBox> bandoContrario = color == "verm" ? azuis : vermel;
                    for (int i = 0; i < bandoContrario.Count; i++)
                    {
                        if (bandoContrario[i].Location == pontoMedio)
                        {
                            bandoContrario[i].Location = new Point(0, 0);
                            bandoContrario[i].Visible = false;
                            return true;
                        }
                    }
                }
                return false;
            }



            private void seDama(string color)
            {
                if (color == "azul" && selecionado.Location.Y == 400)
                {
                    selecionado.BackgroundImage = Properties.Resources.spin_24;
                    selecionado.Tag = "queen";
                }

                else if (color == "verm" && selecionado.Location.Y == 50)
                {
                    selecionado.BackgroundImage = Properties.Resources.botao;
                    selecionado.Tag = "queen";
                }
            }



            private void selecaoVerm(object sender, MouseEventArgs e)
            {
        }

        private void SelecaoVerm(object sender, MouseEventArgs e)
        {
            selecao(sender);
        }
        private void selecaoAzul(object sender, MouseEventArgs e)
        { selecao(sender);}




        private void FormDamas_Load(object sender, EventArgs e)
            {

            }



    private void oTabuleiro_Load(object sender, EventArgs e)
        {

        }

        private void azul11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {

        }

    }
}
