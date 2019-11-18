namespace emWinFontCreator
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
            this.ComboBoxFonts = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTopOffset = new System.Windows.Forms.TextBox();
            this.textBoxBottomOffset = new System.Windows.Forms.TextBox();
            this.textBoxLeftOffset = new System.Windows.Forms.TextBox();
            this.textBoxRightOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxFonts
            // 
            this.ComboBoxFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxFonts.FormattingEnabled = true;
            this.ComboBoxFonts.Location = new System.Drawing.Point(31, 12);
            this.ComboBoxFonts.Name = "ComboBoxFonts";
            this.ComboBoxFonts.Size = new System.Drawing.Size(159, 21);
            this.ComboBoxFonts.TabIndex = 0;
            this.ComboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFonts_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 400);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "A";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(458, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "20";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(469, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(563, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(764, 13);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "400";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(661, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "400";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Size:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTopOffset
            // 
            this.textBoxTopOffset.Location = new System.Drawing.Point(961, 39);
            this.textBoxTopOffset.Name = "textBoxTopOffset";
            this.textBoxTopOffset.Size = new System.Drawing.Size(36, 20);
            this.textBoxTopOffset.TabIndex = 14;
            this.textBoxTopOffset.Text = "0";
            this.textBoxTopOffset.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBoxTopOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBoxBottomOffset
            // 
            this.textBoxBottomOffset.Location = new System.Drawing.Point(961, 65);
            this.textBoxBottomOffset.Name = "textBoxBottomOffset";
            this.textBoxBottomOffset.Size = new System.Drawing.Size(36, 20);
            this.textBoxBottomOffset.TabIndex = 15;
            this.textBoxBottomOffset.Text = "380";
            this.textBoxBottomOffset.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBoxBottomOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBoxLeftOffset
            // 
            this.textBoxLeftOffset.Location = new System.Drawing.Point(961, 91);
            this.textBoxLeftOffset.Name = "textBoxLeftOffset";
            this.textBoxLeftOffset.Size = new System.Drawing.Size(36, 20);
            this.textBoxLeftOffset.TabIndex = 16;
            this.textBoxLeftOffset.Text = "0";
            this.textBoxLeftOffset.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBoxLeftOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // textBoxRightOffset
            // 
            this.textBoxRightOffset.Location = new System.Drawing.Point(961, 117);
            this.textBoxRightOffset.Name = "textBoxRightOffset";
            this.textBoxRightOffset.Size = new System.Drawing.Size(36, 20);
            this.textBoxRightOffset.TabIndex = 17;
            this.textBoxRightOffset.Text = "380";
            this.textBoxRightOffset.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBoxRightOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Top Offset:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bottom Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(882, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Left Offset:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(882, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Right Offset:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(898, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Take Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRightOffset);
            this.Controls.Add(this.textBoxLeftOffset);
            this.Controls.Add(this.textBoxBottomOffset);
            this.Controls.Add(this.textBoxTopOffset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBoxFonts);
            this.Name = "Form1";
            this.Text = "Emwin Font Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxFonts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTopOffset;
        private System.Windows.Forms.TextBox textBoxBottomOffset;
        private System.Windows.Forms.TextBox textBoxLeftOffset;
        private System.Windows.Forms.TextBox textBoxRightOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

