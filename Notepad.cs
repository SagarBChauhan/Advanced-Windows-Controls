using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Practical4
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //RichTxt.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                RichTxt.LoadFile("Hello.rtf");
            }
            else
            {
                MessageBox.Show("The file you've chosen is not a text file");
            }  
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Text = "";
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(saveFileDialog1.FileName +".txt",RichTxt.Text);
                RichTxt.SaveFile("Hello.rtf");
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
                 
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            RichTxt.SaveFile(saveFileDialog1.FileName);

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           pageSetupDialog1.ShowDialog();
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Undo();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.SelectedText = "";
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxt.Text += DateTime.Now;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTxt.Font = fontDialog1.Font;
            }
        }
    }
}
