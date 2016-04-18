using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class fSitings : Form
    {
        public fSitings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Viktorin.allDir = chbAllDirect.Checked;
            Viktorin.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Viktorin.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Viktorin.randomStart = cbRandomStart.Checked;
            Viktorin.WriteParams();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        void Set()
        {
            chbAllDirect.Checked = Viktorin.allDir;
            cbGameDuration.Text = Viktorin.gameDuration.ToString();
            cbMusicDuration.Text = Viktorin.musicDuration.ToString();
            cbRandomStart.Checked = Viktorin.randomStart;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] mus_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", chbAllDirect.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Viktorin.lastFolser = fbd.SelectedPath;
                lbList.Items.Clear();
                lbList.Items.AddRange(mus_list);
                Viktorin.list.Clear();
                Viktorin.list.AddRange(mus_list);
            }
        }

        private void fSitings_Load(object sender, EventArgs e)
        {
            Set();
            lbList.Items.Clear();
            lbList.Items.AddRange(Viktorin.list.ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
