namespace _3ohda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            button4 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 511);
            button1.Name = "button1";
            button1.Size = new Size(164, 38);
            button1.TabIndex = 0;
            button1.Text = "Show non-returned items";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 561);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(348, 311);
            button3.Name = "button3";
            button3.Size = new Size(119, 56);
            button3.TabIndex = 12;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 70);
            label3.Name = "label3";
            label3.Size = new Size(303, 47);
            label3.TabIndex = 10;
            label3.Text = "Add new category";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(34, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 561);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(334, 390);
            button2.Name = "button2";
            button2.Size = new Size(119, 56);
            button2.TabIndex = 10;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 38);
            label2.Name = "label2";
            label2.Size = new Size(275, 47);
            label2.TabIndex = 9;
            label2.Text = "Add new person";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ضابط صف", "ملازم", "ملازم اول", "نقيب", "رائد", "مقدم", "عقيد", "عميد", "لواء", "فريق", "فريق اول", "مشير" });
            comboBox1.Location = new Point(305, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 8;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(760, 493);
            dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(comboBox2);
            panel4.Location = new Point(402, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 561);
            panel4.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(361, 456);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(310, 333);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 11;
            label9.Text = "Notes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(310, 294);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 10;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(310, 253);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 9;
            label7.Text = "Place";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(310, 378);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 8;
            label6.Text = "Serial Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 211);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 7;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(400, 375);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(400, 335);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(400, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(400, 291);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(400, 211);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 830);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button2;
        private Panel panel3;
        private Label label3;
        private Button button3;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button4;
    }
}
