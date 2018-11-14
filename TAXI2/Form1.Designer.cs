namespace TAXI2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbkilometers = new System.Windows.Forms.TextBox();
            this.TbTime = new System.Windows.Forms.Button();
            this.Cbhour = new System.Windows.Forms.ComboBox();
            this.Cbmin = new System.Windows.Forms.ComboBox();
            this.rbam = new System.Windows.Forms.RadioButton();
            this.rbpm = new System.Windows.Forms.RadioButton();
            this.Fare = new System.Windows.Forms.Button();
            this.tbfareamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PassengerId";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassengerName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 162);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 38);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(26, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "km";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbkilometers
            // 
            this.tbkilometers.Location = new System.Drawing.Point(181, 227);
            this.tbkilometers.Multiline = true;
            this.tbkilometers.Name = "tbkilometers";
            this.tbkilometers.Size = new System.Drawing.Size(59, 44);
            this.tbkilometers.TabIndex = 5;
            this.tbkilometers.TextChanged += new System.EventHandler(this.tbkilometers_TextChanged);
            // 
            // TbTime
            // 
            this.TbTime.BackColor = System.Drawing.Color.Black;
            this.TbTime.Location = new System.Drawing.Point(26, 368);
            this.TbTime.Name = "TbTime";
            this.TbTime.Size = new System.Drawing.Size(116, 35);
            this.TbTime.TabIndex = 6;
            this.TbTime.Text = "time";
            this.TbTime.UseVisualStyleBackColor = false;
            this.TbTime.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cbhour
            // 
            this.Cbhour.FormattingEnabled = true;
            this.Cbhour.Location = new System.Drawing.Point(166, 366);
            this.Cbhour.Name = "Cbhour";
            this.Cbhour.Size = new System.Drawing.Size(86, 24);
            this.Cbhour.TabIndex = 7;
            this.Cbhour.Text = "HR";
            this.Cbhour.SelectedIndexChanged += new System.EventHandler(this.Cbhour_SelectedIndexChanged);
            // 
            // Cbmin
            // 
            this.Cbmin.FormattingEnabled = true;
            this.Cbmin.Location = new System.Drawing.Point(166, 396);
            this.Cbmin.Name = "Cbmin";
            this.Cbmin.Size = new System.Drawing.Size(86, 24);
            this.Cbmin.TabIndex = 8;
            this.Cbmin.Text = "MIN";
            // 
            // rbam
            // 
            this.rbam.AutoSize = true;
            this.rbam.ForeColor = System.Drawing.Color.White;
            this.rbam.Location = new System.Drawing.Point(266, 443);
            this.rbam.Name = "rbam";
            this.rbam.Size = new System.Drawing.Size(49, 21);
            this.rbam.TabIndex = 9;
            this.rbam.TabStop = true;
            this.rbam.Text = "AM";
            this.rbam.UseVisualStyleBackColor = true;
            // 
            // rbpm
            // 
            this.rbpm.AutoSize = true;
            this.rbpm.ForeColor = System.Drawing.Color.White;
            this.rbpm.Location = new System.Drawing.Point(332, 443);
            this.rbpm.Name = "rbpm";
            this.rbpm.Size = new System.Drawing.Size(49, 21);
            this.rbpm.TabIndex = 10;
            this.rbpm.TabStop = true;
            this.rbpm.Text = "PM";
            this.rbpm.UseVisualStyleBackColor = true;
            // 
            // Fare
            // 
            this.Fare.BackColor = System.Drawing.Color.Black;
            this.Fare.Location = new System.Drawing.Point(645, 485);
            this.Fare.Name = "Fare";
            this.Fare.Size = new System.Drawing.Size(180, 35);
            this.Fare.TabIndex = 14;
            this.Fare.Text = "Total Fare Amount ";
            this.Fare.UseVisualStyleBackColor = false;
            this.Fare.Click += new System.EventHandler(this.Fare_Click);
            // 
            // tbfareamount
            // 
            this.tbfareamount.Location = new System.Drawing.Point(870, 491);
            this.tbfareamount.Multiline = true;
            this.tbfareamount.Name = "tbfareamount";
            this.tbfareamount.Size = new System.Drawing.Size(100, 29);
            this.tbfareamount.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(395, 68);
            this.label3.TabIndex = 16;
            this.label3.Text = "Taxi Booking Software";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(23, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "SCHEDULE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Presidency University",
            "Yelahanka",
            "BTM Layout",
            "HSR Layout",
            "Banashankari",
            "Jayanagar",
            "Koramangala"});
            this.comboBox1.Location = new System.Drawing.Point(734, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(606, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "From";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(606, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "To";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Presidency University",
            "Yelahanka",
            "BTM Layout",
            "HSR Layout",
            "Banashankari",
            "Jayanagar",
            "Koramangala"});
            this.comboBox2.Location = new System.Drawing.Point(734, 226);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(634, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 38);
            this.label7.TabIndex = 22;
            this.label7.Text = "Location";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1071, 641);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfareamount);
            this.Controls.Add(this.Fare);
            this.Controls.Add(this.rbpm);
            this.Controls.Add(this.rbam);
            this.Controls.Add(this.Cbmin);
            this.Controls.Add(this.Cbhour);
            this.Controls.Add(this.TbTime);
            this.Controls.Add(this.tbkilometers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbkilometers;
        private System.Windows.Forms.Button TbTime;
        private System.Windows.Forms.ComboBox Cbhour;
        private System.Windows.Forms.ComboBox Cbmin;
        private System.Windows.Forms.RadioButton rbam;
        private System.Windows.Forms.RadioButton rbpm;
        private System.Windows.Forms.Button Fare;
        private System.Windows.Forms.TextBox tbfareamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}

