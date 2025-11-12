using System.Drawing;

namespace Library_Management_System
{
    partial class IssueBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            label13 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(353, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 479);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 15);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(353, 53);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 422);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(77, 301);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 6;
            label12.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 301);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 5;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 192);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 4;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 79);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 3;
            label9.Text = "0";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 251);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 2;
            label8.Text = "Fine Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 140);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 1;
            label7.Text = "Returned Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 33);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 0;
            label6.Text = "Issued Books";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 53);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 423);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(3, 323);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(336, 44);
            button3.TabIndex = 14;
            button3.Text = "Re-Issue Book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(6, 336);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(83, 276);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 27);
            textBox5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 277);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(83, 188);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 27);
            textBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 189);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Contact";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 105);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 107);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "User ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 33);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 204, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(3, 375);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(336, 44);
            button2.TabIndex = 4;
            button2.Text = "Issue Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IssueBook";
            Size = new Size(509, 480);
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label12;
        private Label label13;
        private Button button3;
    }
}
