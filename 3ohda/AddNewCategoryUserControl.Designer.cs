namespace _3ohda
{
    partial class AddNewCategoryUserControl
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
            AddNewCategoryPanel = new Panel();
            AddNewCategoryButton = new Button();
            AddNewCategoryTextBox = new TextBox();
            AddNewCategoryLabel = new Label();
            AddNewCategoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewCategoryPanel
            // 
            AddNewCategoryPanel.Controls.Add(AddNewCategoryButton);
            AddNewCategoryPanel.Controls.Add(AddNewCategoryTextBox);
            AddNewCategoryPanel.Controls.Add(AddNewCategoryLabel);
            AddNewCategoryPanel.Dock = DockStyle.Fill;
            AddNewCategoryPanel.Location = new Point(0, 0);
            AddNewCategoryPanel.Name = "AddNewCategoryPanel";
            AddNewCategoryPanel.Size = new Size(800, 600);
            AddNewCategoryPanel.TabIndex = 5;
            // 
            // AddNewCategoryButton
            // 
            AddNewCategoryButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewCategoryButton.Location = new Point(348, 311);
            AddNewCategoryButton.Name = "AddNewCategoryButton";
            AddNewCategoryButton.Size = new Size(119, 56);
            AddNewCategoryButton.TabIndex = 12;
            AddNewCategoryButton.Text = "Add";
            AddNewCategoryButton.UseVisualStyleBackColor = true;
            AddNewCategoryButton.Click += AddNewCategoryButton_Click;
            // 
            // AddNewCategoryTextBox
            // 
            AddNewCategoryTextBox.Location = new Point(318, 215);
            AddNewCategoryTextBox.Name = "AddNewCategoryTextBox";
            AddNewCategoryTextBox.Size = new Size(176, 23);
            AddNewCategoryTextBox.TabIndex = 11;
            // 
            // AddNewCategoryLabel
            // 
            AddNewCategoryLabel.AutoSize = true;
            AddNewCategoryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewCategoryLabel.Location = new Point(258, 70);
            AddNewCategoryLabel.Name = "AddNewCategoryLabel";
            AddNewCategoryLabel.Size = new Size(303, 47);
            AddNewCategoryLabel.TabIndex = 10;
            AddNewCategoryLabel.Text = "Add new category";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddNewCategoryPanel);
            Name = "UserControl1";
            Size = new Size(800, 600);
            AddNewCategoryPanel.ResumeLayout(false);
            AddNewCategoryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddNewCategoryPanel;
        private Button AddNewCategoryButton;
        private TextBox AddNewCategoryTextBox;
        private Label AddNewCategoryLabel;
    }
}
