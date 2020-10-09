namespace Practical4
{
    partial class TextEditor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.BtnUnderline = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(682, 452);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(199, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(326, 12);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(51, 23);
            this.BtnBold.TabIndex = 2;
            this.BtnBold.Text = "B";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Location = new System.Drawing.Point(383, 12);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(51, 23);
            this.BtnItalic.TabIndex = 2;
            this.BtnItalic.Text = "I";
            this.BtnItalic.UseVisualStyleBackColor = true;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // BtnUnderline
            // 
            this.BtnUnderline.Location = new System.Drawing.Point(440, 12);
            this.BtnUnderline.Name = "BtnUnderline";
            this.BtnUnderline.Size = new System.Drawing.Size(51, 23);
            this.BtnUnderline.TabIndex = 2;
            this.BtnUnderline.Text = "U";
            this.BtnUnderline.UseVisualStyleBackColor = true;
            this.BtnUnderline.Click += new System.EventHandler(this.BtnUnderline_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(499, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(539, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Fore";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Left";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(619, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Center";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(660, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Right";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 505);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnUnderline);
            this.Controls.Add(this.BtnItalic);
            this.Controls.Add(this.BtnBold);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnItalic;
        private System.Windows.Forms.Button BtnUnderline;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}