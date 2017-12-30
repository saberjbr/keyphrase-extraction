namespace Test
{
    partial class Form1
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
            this.process = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveToDocsChckBx = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keywordGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.keyCountTxtbx = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Catlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 459);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(33, 484);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(150, 35);
            this.process.TabIndex = 1;
            this.process.Text = "بگرد";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyCountTxtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveToDocsChckBx);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.process);
            this.groupBox1.Location = new System.Drawing.Point(481, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(488, 525);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // saveToDocsChckBx
            // 
            this.saveToDocsChckBx.AutoSize = true;
            this.saveToDocsChckBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToDocsChckBx.Location = new System.Drawing.Point(362, 494);
            this.saveToDocsChckBx.Name = "saveToDocsChckBx";
            this.saveToDocsChckBx.Size = new System.Drawing.Size(94, 17);
            this.saveToDocsChckBx.TabIndex = 2;
            this.saveToDocsChckBx.Text = "ذخیره در اسناد";
            this.saveToDocsChckBx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToDocsChckBx.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(463, 525);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نتایج";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.keywordGridView);
            this.groupBox3.Location = new System.Drawing.Point(17, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 251);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "کلمات کلیدی";
            // 
            // keywordGridView
            // 
            this.keywordGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keywordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keywordGridView.Location = new System.Drawing.Point(11, 21);
            this.keywordGridView.Name = "keywordGridView";
            this.keywordGridView.Size = new System.Drawing.Size(405, 217);
            this.keywordGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد کلمات:";
            // 
            // keyCountTxtbx
            // 
            this.keyCountTxtbx.Location = new System.Drawing.Point(220, 492);
            this.keyCountTxtbx.Name = "keyCountTxtbx";
            this.keyCountTxtbx.Size = new System.Drawing.Size(39, 20);
            this.keyCountTxtbx.TabIndex = 4;
            this.keyCountTxtbx.Text = "6";
            this.keyCountTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyCountTxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Catlabel);
            this.groupBox4.Location = new System.Drawing.Point(17, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "دسته بندی";
            // 
            // Catlabel
            // 
            this.Catlabel.AutoSize = true;
            this.Catlabel.Location = new System.Drawing.Point(384, 36);
            this.Catlabel.Name = "Catlabel";
            this.Catlabel.Size = new System.Drawing.Size(0, 13);
            this.Catlabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keywordGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox saveToDocsChckBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView keywordGridView;
        private System.Windows.Forms.TextBox keyCountTxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Catlabel;
    }
}

