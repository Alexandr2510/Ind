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

namespace ind
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);

                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
                tbDir.ReadOnly = false;
                tbDir.Text = FBD.SelectedPath.ToString();
                tbDir.ReadOnly = true;
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закінчити роботу?", "Закінчення роботи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var Sort = Directory.EnumerateFiles(tbDir.Text, "*", SearchOption.AllDirectories)
                    .OrderByDescending(f => new FileInfo(f).LastWriteTime);

            foreach (string o in Sort)
            {
                listBox2.Items.Add(o);
            }
        }

        private void btnSortSize_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var Sort = Directory.EnumerateFiles(tbDir.Text, "*", SearchOption.AllDirectories)
                    .OrderByDescending(f => new FileInfo(f).Length);

            foreach (string o in Sort)
            {
                listBox2.Items.Add(o);
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var Sort = Directory.EnumerateFiles(tbDir.Text, "*", SearchOption.AllDirectories)
                    .OrderByDescending(f => new FileInfo(f).FullName);

            foreach (string o in Sort)
            {
                listBox2.Items.Add(o);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About abt = new About();
            {
                abt.ShowDialog();
            }
        }
    }
}

