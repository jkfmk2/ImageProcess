using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(dlg.FileName, FileMode.Open))
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    bmp = new Bitmap(ms);
                    pictureBox1.Image = bmp;
                }
            }
        }
    }
}
