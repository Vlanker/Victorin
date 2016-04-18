using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musDuration=Viktorin.musicDuration;

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Viktorin.list.Count == 0) EndGame();
            else
            {
                musDuration = Viktorin.musicDuration;
                int n = rnd.Next(0, Viktorin.list.Count());
                WMP.URL = Viktorin.list[n];
                //WMP.Ctlcontrols.play();
                Viktorin.list.RemoveAt(n);
                lbMelodyCount.Text = Viktorin.list.Count.ToString();
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
            tTime.Start();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            tTime.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lbMelodyCount.Text = Viktorin.list.Count.ToString();
            pbTime.Maximum = Viktorin.gameDuration;
            pbTime.Value = 0;
            pbTime.Minimum = 0;
            lbmusDuration.Text = musDuration.ToString();

        }

        void EndGame()
        {
            tTime.Stop();
            WMP.Ctlcontrols.stop();
            pbTime.Value = 0;
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            pbTime.Value++;
            musDuration--;
            lbmusDuration.Text = musDuration.ToString();
            if (pbTime.Value == pbTime.Maximum)
            {
                EndGame();
                return;
            }
            if (musDuration == 0) MakeMusic();

        }

        private void btnContiny_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        void GamePause()
        {
            tTime.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GameContinue()
        {
            tTime.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.A)
            {
                GamePause();
                if ( MessageBox.Show("Правильно?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbCout1.Text = Convert.ToString(Convert.ToInt32(lbCout1.Text)+1);
                    MakeMusic();
                }
                GameContinue();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                if (MessageBox.Show("Правильно?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    lbCount2.Text = Convert.ToString(Convert.ToInt32(lbCount2.Text) + 1);
                    MakeMusic();
                }
                GameContinue();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Viktorin.randomStart)
            if (WMP.openState==WMPLib.WMPOpenState.wmposMediaOpen)
            {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
            }
        }
    }
}
