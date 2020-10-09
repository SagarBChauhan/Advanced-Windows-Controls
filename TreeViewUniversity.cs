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
    public partial class TreeViewUniversity : Form
    {
        public TreeViewUniversity()
        {
            InitializeComponent();
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {   
            TreeUniversity.Nodes.Add(new TreeNode(TxtIn.Text));
            //TreeUniversity.SelectedNode(new TreeNode(""));
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            TreeUniversity.SelectedNode.Remove();
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            TreeUniversity.ExpandAll();
        }

        private void Btncollapse_Click(object sender, EventArgs e)
        {
            TreeUniversity.CollapseAll();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            TreeUniversity.SelectedNode.Nodes.Add(new TreeNode(TxtIn.Text));
        }

        private void TreeViewUniversity_Load(object sender, EventArgs e)
        {
            
        }
    }   
}
