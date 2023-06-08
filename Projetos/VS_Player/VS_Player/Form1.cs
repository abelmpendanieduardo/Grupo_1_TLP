using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_Player
{
    public partial class Form1 : Form
    {

        private int Volume = 30;
        private int Play = 0;
        public OpenFileDialog arquivo = new OpenFileDialog();
        private string Caminho;

        public Form1()
        {
            InitializeComponent();
        }

        //Funcionalidades de Abrir Arquivo

        private void AbrirMusica()
        {
            try
            {
                mPlay.URL = @"" + Caminho;
                mPlay.Ctlcontrols.play();

                this.Visible = true;
                tSlider.Start();


                tbarDuracao.Enabled = true;
                btnPlayPause.BackgroundImage = Properties.Resources.pause_48px;
            }

            catch
            {

            }
        }

        private void AbrirArquivo()
        {
            arquivo.Title = "Abrir Mídia";
            arquivo.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            DialogResult dres1 = arquivo.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            Caminho = arquivo.FileName;
            txtinPlayList.Text = arquivo.SafeFileName;
        }

        private void tbarDuracao_ValueChanged(object sender, EventArgs e)
        {
            tbarDuracao.Maximum = (int)mPlay.currentMedia.duration;

            if (tbarDuracao.Value == (int)mPlay.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                mPlay.Ctlcontrols.currentPosition = tbarDuracao.Value;
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            tbarDuracao.Value = tbarDuracao.Value + 10;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if ((tbarDuracao.Value = tbarDuracao.Value - 15) < 0)
            {
                tbarDuracao.Value = 0;
            }
            else
            {
                tbarDuracao.Value = tbarDuracao.Value - 15;
            }
        }

        private void tSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                tbarDuracao.Value = (int)mPlay.Ctlcontrols.currentPosition;
                lblInicio.Text = mPlay.Ctlcontrols.currentPositionString;
                lblFim.Text = mPlay.currentMedia.durationString;
            }

            catch
            {

            }
        } 
        
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            lblVSPlayer.Visible = false;
            try
            {
                AbrirArquivo();
                if (Caminho != "")
                {
                    Play = 2;
                    AbrirMusica();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tbarVolume_ValueChanged(object sender, EventArgs e)
        {
            mPlay.settings.volume = tbarVolume.Value;
            lblVolume.Text = mPlay.settings.volume.ToString();
            lblVolume.Visible = true;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (Play == 1)
            {
                AbrirMusica();
                Play = 2;
            }
            else if (Play == 2)
            {
                mPlay.Ctlcontrols.pause();
                tSlider.Stop();
                lblVSPlayer.Visible = true;

                btnPlayPause.BackgroundImage = Properties.Resources.play_48px;
                Play = 3;
            }
            else if (Play == 3)
            {
                mPlay.Ctlcontrols.play();
                tSlider.Start();
                lblVSPlayer.Visible = false;
                panel.Visible = false;

                btnPlayPause.BackgroundImage = Properties.Resources.pause_48px;
                Play = 2;
            }
        }

        private void btnListOpcoes_Click(object sender, EventArgs e)
        {
            pnlOpcoes.Visible = false;
            btnListOpcoes.Visible = false;
            btnFecharListOpcoes.Visible = true;

        }

        private void btnFecharListOpcoes_Click(object sender, EventArgs e)
        {
            pnlOpcoes.Visible = true; ;
            btnFecharListOpcoes.Visible = false;
            btnListOpcoes.Visible = true;
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
