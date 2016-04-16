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
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] mus_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", chbAllDirect.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                lbList.Items.Clear();
                lbList.Items.AddRange(mus_list);
                Viktorin.list.Clear();
                Viktorin.list.AddRange(mus_list);
            }
        }
    }
}
