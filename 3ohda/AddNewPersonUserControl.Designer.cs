
using MySql.Data.MySqlClient;

namespace _3ohda
{
    partial class AddNewPersonUserControl
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
            AddNewPersonPanel = new Panel();
            AddNewPersonButton = new Button();
            AddNewPersonLabel = new Label();
            AddNewPersonRankCombobox = new ComboBox();
            textBox1 = new TextBox();
            AddNewPersonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewPersonPanel
            // 
            AddNewPersonPanel.Controls.Add(AddNewPersonButton);
            AddNewPersonPanel.Controls.Add(AddNewPersonLabel);
            AddNewPersonPanel.Controls.Add(AddNewPersonRankCombobox);
            AddNewPersonPanel.Controls.Add(textBox1);
            AddNewPersonPanel.Dock = DockStyle.Fill;
            AddNewPersonPanel.Location = new Point(0, 0);
            AddNewPersonPanel.Name = "AddNewPersonPanel";
            AddNewPersonPanel.Size = new Size(800, 600);
            AddNewPersonPanel.TabIndex = 4;
            // 
            // AddNewPersonButton
            // 
            AddNewPersonButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewPersonButton.Location = new Point(334, 390);
            AddNewPersonButton.Name = "AddNewPersonButton";
            AddNewPersonButton.Size = new Size(119, 56);
            AddNewPersonButton.TabIndex = 10;
            AddNewPersonButton.Text = "Add";
            AddNewPersonButton.UseVisualStyleBackColor = true;
            AddNewPersonButton.Click += this.AddNewPersonButton_Click;
            // 
            // AddNewPersonLabel
            // 
            AddNewPersonLabel.AutoSize = true;
            AddNewPersonLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewPersonLabel.Location = new Point(259, 38);
            AddNewPersonLabel.Name = "AddNewPersonLabel";
            AddNewPersonLabel.Size = new Size(275, 47);
            AddNewPersonLabel.TabIndex = 9;
            AddNewPersonLabel.Text = "Add new person";
            // 
            // AddNewPersonRankCombobox
            // 
            AddNewPersonRankCombobox.FormattingEnabled = true;
            AddNewPersonRankCombobox.Items.AddRange(new object[] { "ضابط صف", "ملازم", "ملازم اول", "نقيب", "رائد", "مقدم", "عقيد", "عميد", "لواء", "فريق", "فريق اول", "مشير" });
            AddNewPersonRankCombobox.Location = new Point(305, 221);
            AddNewPersonRankCombobox.Name = "AddNewPersonRankCombobox";
            AddNewPersonRankCombobox.Size = new Size(176, 23);
            AddNewPersonRankCombobox.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 0;
            // 
            // AddNewPersonUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddNewPersonPanel);
            Name = "AddNewPersonUserControl";
            Size = new Size(800, 600);
            AddNewPersonPanel.ResumeLayout(false);
            AddNewPersonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddNewPersonPanel;
        private Button AddNewPersonButton;
        private Label AddNewPersonLabel;
        private ComboBox AddNewPersonRankCombobox;
        private TextBox textBox1;
    }
}
