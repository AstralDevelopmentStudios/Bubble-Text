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
namespace Bubble_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text File|*.txt|Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = of.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
            catch
            {
                OpenDlg();
            }
        }

        private void SaveDlg()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text File|*.txt|Any File|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sf.FileName);
                sr.Write(richTextBox1.Text);
                sr.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }
    }
}
