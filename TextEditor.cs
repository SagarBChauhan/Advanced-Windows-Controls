using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Practical4
{
    public partial class TextEditor : Form
    {
        int i ,u,b= 0;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBold_Click(object sender, EventArgs e)
        {          
            if (b == 0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
                BtnBold.Font = new Font(BtnBold.Font, FontStyle.Bold);
                b = 1;
            }
            else if(b==1)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                BtnBold.Font = new Font(BtnBold.Font, FontStyle.Regular);
                b = 0; 
            }
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
                BtnItalic.Font = new Font(BtnItalic.Font, FontStyle.Italic);
                i = 1;
            }
            else if (i == 1)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                BtnItalic.Font = new Font(BtnItalic.Font, FontStyle.Regular);
                i = 0;
            }
        }

        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            if (u == 0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
                BtnUnderline.Font = new Font(BtnUnderline.Font, FontStyle.Underline);
                u = 1;
            }
            else if (u == 1)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                BtnUnderline.Font = new Font(BtnUnderline.Font, FontStyle.Regular);
                u = 0;
            }
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily family in fonts.Families)
            {
                comboBox1.Items.Add(family.Name);
            }
            comboBox1.SelectedIndex = 2;
           
        }
    }
}
