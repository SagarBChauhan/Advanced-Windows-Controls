namespace Practical4
{
    partial class greeting
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.PicPerson = new System.Windows.Forms.PictureBox();
            this.LblNAme = new System.Windows.Forms.Label();
            this.LblHBD = new System.Windows.Forms.Label();
            this.buttonColour = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.LblEnterName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPerson)).BeginInit();
            this.grpInput.SuspendLayout();
            this.GrpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(258, 102);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(253, 22);
            this.TxtName.TabIndex = 9;
            // 
            // BtnClick
            // 
            this.BtnClick.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnClick.Font = new System.Drawing.Font("ThimbaSSK", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClick.Location = new System.Drawing.Point(278, 269);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(117, 78);
            this.BtnClick.TabIndex = 8;
            this.BtnClick.Text = "ClickMe";
            this.BtnClick.UseVisualStyleBackColor = false;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // PicPerson
            // 
            this.PicPerson.Location = new System.Drawing.Point(100, 243);
            this.PicPerson.Name = "PicPerson";
            this.PicPerson.Size = new System.Drawing.Size(461, 251);
            this.PicPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPerson.TabIndex = 7;
            this.PicPerson.TabStop = false;
            // 
            // LblNAme
            // 
            this.LblNAme.AutoSize = true;
            this.LblNAme.Font = new System.Drawing.Font("Waltograph UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNAme.ForeColor = System.Drawing.Color.Purple;
            this.LblNAme.Location = new System.Drawing.Point(35, 125);
            this.LblNAme.Name = "LblNAme";
            this.LblNAme.Size = new System.Drawing.Size(280, 93);
            this.LblNAme.TabIndex = 6;
            this.LblNAme.Text = "Name";
            // 
            // LblHBD
            // 
            this.LblHBD.AutoSize = true;
            this.LblHBD.Font = new System.Drawing.Font("Waltograph UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHBD.ForeColor = System.Drawing.Color.Purple;
            this.LblHBD.Location = new System.Drawing.Point(40, 46);
            this.LblHBD.Name = "LblHBD";
            this.LblHBD.Size = new System.Drawing.Size(556, 66);
            this.LblHBD.TabIndex = 5;
            this.LblHBD.Text = "Happy Birthday";
            // 
            // buttonColour
            // 
            this.buttonColour.Location = new System.Drawing.Point(159, 181);
            this.buttonColour.Name = "buttonColour";
            this.buttonColour.Size = new System.Drawing.Size(81, 38);
            this.buttonColour.TabIndex = 10;
            this.buttonColour.Text = "Colour";
            this.buttonColour.UseVisualStyleBackColor = true;
            this.buttonColour.Click += new System.EventHandler(this.buttonCh_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(297, 181);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(81, 38);
            this.BtnFont.TabIndex = 11;
            this.BtnFont.Text = "Font";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(430, 181);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(81, 38);
            this.BtnImage.TabIndex = 11;
            this.BtnImage.Text = "Image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.LblEnterName);
            this.grpInput.Controls.Add(this.buttonColour);
            this.grpInput.Controls.Add(this.TxtName);
            this.grpInput.Controls.Add(this.BtnClick);
            this.grpInput.Controls.Add(this.BtnImage);
            this.grpInput.Controls.Add(this.BtnFont);
            this.grpInput.Location = new System.Drawing.Point(18, 27);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(631, 597);
            this.grpInput.TabIndex = 12;
            this.grpInput.TabStop = false;
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.PicPerson);
            this.GrpResult.Controls.Add(this.LblNAme);
            this.GrpResult.Controls.Add(this.LblHBD);
            this.GrpResult.Location = new System.Drawing.Point(16, 26);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(631, 597);
            this.GrpResult.TabIndex = 13;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "Result";
            this.GrpResult.Enter += new System.EventHandler(this.GrpResult_Enter);
            // 
            // LblEnterName
            // 
            this.LblEnterName.AutoSize = true;
            this.LblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnterName.Location = new System.Drawing.Point(156, 107);
            this.LblEnterName.Name = "LblEnterName";
            this.LblEnterName.Size = new System.Drawing.Size(98, 17);
            this.LblEnterName.TabIndex = 12;
            this.LblEnterName.Text = "Enter Name:";
            // 
            // greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 640);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.GrpResult);
            this.Name = "greeting";
            this.Text = "greeting";
            ((System.ComponentModel.ISupportInitialize)(this.PicPerson)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.GrpResult.ResumeLayout(false);
            this.GrpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.PictureBox PicPerson;
        private System.Windows.Forms.Label LblNAme;
        private System.Windows.Forms.Label LblHBD;
        private System.Windows.Forms.Button buttonColour;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Label LblEnterName;
    }
}