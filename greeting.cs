using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical4
{
    public partial class greeting : Form
    {
        public greeting()
        {
            InitializeComponent();
        }

        private void buttonCh_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LblHBD.ForeColor = colorDialog1.Color;
                LblNAme.ForeColor = colorDialog1.Color;
                buttonColour.BackColor = colorDialog1.Color;
                BtnClick.BackColor = colorDialog1.Color;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LblHBD.Font = fontDialog1.Font;
                LblNAme.Font = fontDialog1.Font;
                BtnFont.Font = fontDialog1.Font;
                BtnClick.Font = fontDialog1.Font;
               
            }
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicPerson.Image = Image.FromFile(openFileDialog1.FileName);
            
            }
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            GrpResult.Show();
            grpInput.Hide();
            LblNAme.Text = TxtName.Text;
        }

        private void greeting_Load(object sender, EventArgs e)
        {
            GrpResult.Hide();
            grpInput.Show();
        }

        private void GrpResult_Enter(object sender, EventArgs e)
        {

        }
    }
}
