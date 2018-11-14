namespace calci
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(339, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(432, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(163, 157);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 50);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(278, 157);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 50);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(384, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(163, 280);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(278, 280);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(384, 280);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(278, 339);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 50);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(384, 339);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(75, 50);
            this.bc.TabIndex = 11;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(481, 280);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(75, 47);
            this.bmult.TabIndex = 13;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(481, 339);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 50);
            this.bdiv.TabIndex = 14;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(481, 217);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(75, 49);
            this.bsub.TabIndex = 15;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bad
            // 
            this.bad.Location = new System.Drawing.Point(481, 157);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(75, 50);
            this.bad.TabIndex = 16;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bequal
            // 
            this.bequal.Location = new System.Drawing.Point(321, 415);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(75, 53);
            this.bequal.TabIndex = 17;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(880, 553);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bequal;
    }
}

