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

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            int n = rnd.Next(0, Viktorin.list.Count());
            WMP.URL = Viktorin.list[n];
            //WMP.Ctlcontrols.play();
            Viktorin.list.RemoveAt(n);
            lbMelodyCount.Text = Viktorin.list.Count.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
            tTime.Start();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tTime.Stop();
            WMP.Ctlcontrols.pause();

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

        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            pbTime.Value++;
            if (pbTime.Value == pbTime.Maximum)
            {
                tTime.Stop();
                WMP.Ctlcontrols.stop();
                pbTime.Value = 0;
            }

        }

        private void btnContiny_Click(object sender, EventArgs e)
        {
            tTime.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
