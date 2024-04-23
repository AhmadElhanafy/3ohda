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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(790, 0);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 830);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}
