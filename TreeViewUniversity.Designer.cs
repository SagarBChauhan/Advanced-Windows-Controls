namespace Practical4
{
    partial class TreeViewUniversity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeUniversity = new System.Windows.Forms.TreeView();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.Btncollapse = new System.Windows.Forms.Button();
            this.BtnCount = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeUniversity
            // 
            this.TreeUniversity.Location = new System.Drawing.Point(40, 34);
            this.TreeUniversity.Name = "TreeUniversity";
            this.TreeUniversity.Size = new System.Drawing.Size(291, 323);
            this.TreeUniversity.TabIndex = 0;
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(353, 279);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(103, 33);
            this.BtnAddRoot.TabIndex = 1;
            this.BtnAddRoot.Text = "Add Root";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(353, 34);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(103, 33);
            this.BtnRemove.TabIndex = 1;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Location = new System.Drawing.Point(353, 79);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(103, 33);
            this.BtnExpand.TabIndex = 1;
            this.BtnExpand.Text = "Expand";
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // Btncollapse
            // 
            this.Btncollapse.Location = new System.Drawing.Point(353, 121);
            this.Btncollapse.Name = "Btncollapse";
            this.Btncollapse.Size = new System.Drawing.Size(103, 33);
            this.Btncollapse.TabIndex = 1;
            this.Btncollapse.Text = "Collapse";
            this.Btncollapse.UseVisualStyleBackColor = true;
            this.Btncollapse.Click += new System.EventHandler(this.Btncollapse_Click);
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(353, 164);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(103, 33);
            this.BtnCount.TabIndex = 1;
            this.BtnCount.Text = "Count";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(353, 210);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(103, 33);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(353, 324);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(103, 33);
            this.BtnAddChild.TabIndex = 1;
            this.BtnAddChild.Text = "AddChild";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(131, 374);
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(199, 22);
            this.TxtIn.TabIndex = 2;
            this.TxtIn.Text = "Node0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Node Name:";
            // 
            // TreeViewUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIn);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCount);
            this.Controls.Add(this.Btncollapse);
            this.Controls.Add(this.BtnExpand);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAddChild);
            this.Controls.Add(this.BtnAddRoot);
            this.Controls.Add(this.TreeUniversity);
            this.Name = "TreeViewUniversity";
            this.Text = "TreeViewUniversity";
            this.Load += new System.EventHandler(this.TreeViewUniversity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeUniversity;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnExpand;
        private System.Windows.Forms.Button Btncollapse;
        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Label label1;
    }
}