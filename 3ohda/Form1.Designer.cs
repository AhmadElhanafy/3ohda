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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            AddNewCategoryPanel = new Panel();
            AddNewCategoryButton = new Button();
            AddNewPersonPanel = new Panel();
            AddNewPersonButton = new Button();
            AddNewPersonLabel = new Label();
            AddNewPersonRankCombobox = new ComboBox();
            textBox1 = new TextBox();
            AddNewCategoryTextBox = new TextBox();
            AddNewCategoryLabel = new Label();
            AddNewItemPanel = new Panel();
            AddNewItemLabel = new Label();
            AddNewItemButton = new Button();
            AddNewItemNotesLabel = new Label();
            AddNewItemStatusLabel = new Label();
            AddNewItemPlaceLabel = new Label();
            AddNewItemSerialNumberLabel = new Label();
            AddNewItemCategoryLabel = new Label();
            AddNewItemNameLabel = new Label();
            AddNewItemSerialNumberTextbox = new TextBox();
            AddNewItemNotesTextbox = new TextBox();
            AddNewItemPlaceTextbox = new TextBox();
            AddNewItemNameTextbox = new TextBox();
            AddNewItemStatusCombobox = new ComboBox();
            AddNewItemCategoryCombobox = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            personToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AddNewCategoryPanel.SuspendLayout();
            AddNewPersonPanel.SuspendLayout();
            AddNewItemPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1157, 102);
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
            // AddNewCategoryPanel
            // 
            AddNewCategoryPanel.Controls.Add(AddNewCategoryButton);
            AddNewCategoryPanel.Controls.Add(AddNewPersonPanel);
            AddNewCategoryPanel.Controls.Add(AddNewCategoryTextBox);
            AddNewCategoryPanel.Controls.Add(AddNewCategoryLabel);
            AddNewCategoryPanel.Enabled = false;
            AddNewCategoryPanel.Location = new Point(12, 27);
            AddNewCategoryPanel.Name = "AddNewCategoryPanel";
            AddNewCategoryPanel.Size = new Size(800, 600);
            AddNewCategoryPanel.TabIndex = 4;
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
            AddNewCategoryButton.Click += button3_Click;
            // 
            // AddNewPersonPanel
            // 
            AddNewPersonPanel.Controls.Add(AddNewPersonButton);
            AddNewPersonPanel.Controls.Add(AddNewPersonLabel);
            AddNewPersonPanel.Controls.Add(AddNewPersonRankCombobox);
            AddNewPersonPanel.Controls.Add(textBox1);
            AddNewPersonPanel.Enabled = false;
            AddNewPersonPanel.Location = new Point(849, 57);
            AddNewPersonPanel.Name = "AddNewPersonPanel";
            AddNewPersonPanel.Size = new Size(800, 600);
            AddNewPersonPanel.TabIndex = 3;
            AddNewPersonPanel.Visible = false;
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
            AddNewPersonButton.Click += button2_Click;
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
            AddNewPersonRankCombobox.KeyPress += comboBox1_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 0;
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
            // AddNewItemPanel
            // 
            AddNewItemPanel.Controls.Add(panel1);
            AddNewItemPanel.Controls.Add(AddNewItemLabel);
            AddNewItemPanel.Controls.Add(AddNewItemButton);
            AddNewItemPanel.Controls.Add(AddNewItemNotesLabel);
            AddNewItemPanel.Controls.Add(AddNewItemStatusLabel);
            AddNewItemPanel.Controls.Add(AddNewItemPlaceLabel);
            AddNewItemPanel.Controls.Add(AddNewItemSerialNumberLabel);
            AddNewItemPanel.Controls.Add(AddNewItemCategoryLabel);
            AddNewItemPanel.Controls.Add(AddNewItemNameLabel);
            AddNewItemPanel.Controls.Add(AddNewItemSerialNumberTextbox);
            AddNewItemPanel.Controls.Add(AddNewItemNotesTextbox);
            AddNewItemPanel.Controls.Add(AddNewItemPlaceTextbox);
            AddNewItemPanel.Controls.Add(AddNewItemNameTextbox);
            AddNewItemPanel.Controls.Add(AddNewItemStatusCombobox);
            AddNewItemPanel.Controls.Add(AddNewItemCategoryCombobox);
            AddNewItemPanel.Enabled = false;
            AddNewItemPanel.Location = new Point(845, 65);
            AddNewItemPanel.Name = "AddNewItemPanel";
            AddNewItemPanel.Size = new Size(800, 600);
            AddNewItemPanel.TabIndex = 5;
            AddNewItemPanel.Visible = false;
            // 
            // AddNewItemLabel
            // 
            AddNewItemLabel.AutoSize = true;
            AddNewItemLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewItemLabel.Location = new Point(322, 38);
            AddNewItemLabel.Name = "AddNewItemLabel";
            AddNewItemLabel.Size = new Size(195, 40);
            AddNewItemLabel.TabIndex = 13;
            AddNewItemLabel.Text = "Add new item";
            // 
            // AddNewItemButton
            // 
            AddNewItemButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewItemButton.Location = new Point(362, 431);
            AddNewItemButton.Name = "AddNewItemButton";
            AddNewItemButton.Size = new Size(120, 53);
            AddNewItemButton.TabIndex = 12;
            AddNewItemButton.Text = "Add";
            AddNewItemButton.UseVisualStyleBackColor = true;
            AddNewItemButton.Click += button4_Click;
            // 
            // AddNewItemNotesLabel
            // 
            AddNewItemNotesLabel.AutoSize = true;
            AddNewItemNotesLabel.Location = new Point(306, 298);
            AddNewItemNotesLabel.Name = "AddNewItemNotesLabel";
            AddNewItemNotesLabel.Size = new Size(38, 15);
            AddNewItemNotesLabel.TabIndex = 11;
            AddNewItemNotesLabel.Text = "Notes";
            // 
            // AddNewItemStatusLabel
            // 
            AddNewItemStatusLabel.AutoSize = true;
            AddNewItemStatusLabel.Location = new Point(306, 259);
            AddNewItemStatusLabel.Name = "AddNewItemStatusLabel";
            AddNewItemStatusLabel.Size = new Size(39, 15);
            AddNewItemStatusLabel.TabIndex = 10;
            AddNewItemStatusLabel.Text = "Status";
            // 
            // AddNewItemPlaceLabel
            // 
            AddNewItemPlaceLabel.AutoSize = true;
            AddNewItemPlaceLabel.Location = new Point(306, 218);
            AddNewItemPlaceLabel.Name = "AddNewItemPlaceLabel";
            AddNewItemPlaceLabel.Size = new Size(35, 15);
            AddNewItemPlaceLabel.TabIndex = 9;
            AddNewItemPlaceLabel.Text = "Place";
            // 
            // AddNewItemSerialNumberLabel
            // 
            AddNewItemSerialNumberLabel.AutoSize = true;
            AddNewItemSerialNumberLabel.Enabled = false;
            AddNewItemSerialNumberLabel.Location = new Point(306, 343);
            AddNewItemSerialNumberLabel.Name = "AddNewItemSerialNumberLabel";
            AddNewItemSerialNumberLabel.Size = new Size(82, 15);
            AddNewItemSerialNumberLabel.TabIndex = 8;
            AddNewItemSerialNumberLabel.Text = "Serial Number";
            // 
            // AddNewItemCategoryLabel
            // 
            AddNewItemCategoryLabel.AutoSize = true;
            AddNewItemCategoryLabel.Location = new Point(306, 176);
            AddNewItemCategoryLabel.Name = "AddNewItemCategoryLabel";
            AddNewItemCategoryLabel.Size = new Size(55, 15);
            AddNewItemCategoryLabel.TabIndex = 7;
            AddNewItemCategoryLabel.Text = "Category";
            // 
            // AddNewItemNameLabel
            // 
            AddNewItemNameLabel.AutoSize = true;
            AddNewItemNameLabel.Location = new Point(306, 144);
            AddNewItemNameLabel.Name = "AddNewItemNameLabel";
            AddNewItemNameLabel.Size = new Size(39, 15);
            AddNewItemNameLabel.TabIndex = 6;
            AddNewItemNameLabel.Text = "Name";
            // 
            // AddNewItemSerialNumberTextbox
            // 
            AddNewItemSerialNumberTextbox.Enabled = false;
            AddNewItemSerialNumberTextbox.Location = new Point(396, 340);
            AddNewItemSerialNumberTextbox.Name = "AddNewItemSerialNumberTextbox";
            AddNewItemSerialNumberTextbox.Size = new Size(121, 23);
            AddNewItemSerialNumberTextbox.TabIndex = 5;
            // 
            // AddNewItemNotesTextbox
            // 
            AddNewItemNotesTextbox.Location = new Point(396, 300);
            AddNewItemNotesTextbox.Name = "AddNewItemNotesTextbox";
            AddNewItemNotesTextbox.Size = new Size(121, 23);
            AddNewItemNotesTextbox.TabIndex = 4;
            // 
            // AddNewItemPlaceTextbox
            // 
            AddNewItemPlaceTextbox.Location = new Point(396, 215);
            AddNewItemPlaceTextbox.Name = "AddNewItemPlaceTextbox";
            AddNewItemPlaceTextbox.Size = new Size(121, 23);
            AddNewItemPlaceTextbox.TabIndex = 3;
            // 
            // AddNewItemNameTextbox
            // 
            AddNewItemNameTextbox.Location = new Point(396, 137);
            AddNewItemNameTextbox.Name = "AddNewItemNameTextbox";
            AddNewItemNameTextbox.Size = new Size(121, 23);
            AddNewItemNameTextbox.TabIndex = 2;
            // 
            // AddNewItemStatusCombobox
            // 
            AddNewItemStatusCombobox.FormattingEnabled = true;
            AddNewItemStatusCombobox.Location = new Point(396, 256);
            AddNewItemStatusCombobox.Name = "AddNewItemStatusCombobox";
            AddNewItemStatusCombobox.Size = new Size(121, 23);
            AddNewItemStatusCombobox.TabIndex = 1;
            // 
            // AddNewItemCategoryCombobox
            // 
            AddNewItemCategoryCombobox.FormattingEnabled = true;
            AddNewItemCategoryCombobox.Location = new Point(396, 176);
            AddNewItemCategoryCombobox.Name = "AddNewItemCategoryCombobox";
            AddNewItemCategoryCombobox.Size = new Size(121, 23);
            AddNewItemCategoryCombobox.TabIndex = 0;
            AddNewItemCategoryCombobox.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1588, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, addCategoryToolStripMenuItem, personToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 20);
            toolStripMenuItem1.Text = "Add new";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(180, 22);
            addItemToolStripMenuItem.Text = "Item";
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.Size = new Size(180, 22);
            addCategoryToolStripMenuItem.Text = "Category";
            // 
            // personToolStripMenuItem
            // 
            personToolStripMenuItem.Name = "personToolStripMenuItem";
            personToolStripMenuItem.Size = new Size(180, 22);
            personToolStripMenuItem.Text = "Person";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 830);
            Controls.Add(menuStrip1);
            Controls.Add(AddNewCategoryPanel);
            Controls.Add(AddNewItemPanel);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AddNewCategoryPanel.ResumeLayout(false);
            AddNewCategoryPanel.PerformLayout();
            AddNewPersonPanel.ResumeLayout(false);
            AddNewPersonPanel.PerformLayout();
            AddNewItemPanel.ResumeLayout(false);
            AddNewItemPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel AddNewPersonPanel;
        private TextBox textBox1;
        private ComboBox AddNewPersonRankCombobox;
        private Label AddNewPersonLabel;
        private Button AddNewPersonButton;
        private Panel AddNewCategoryPanel;
        private Label AddNewCategoryLabel;
        private Button AddNewCategoryButton;
        private TextBox AddNewCategoryTextBox;
        private Panel AddNewItemPanel;
        private TextBox AddNewItemSerialNumberTextbox;
        private TextBox AddNewItemNotesTextbox;
        private TextBox AddNewItemPlaceTextbox;
        private TextBox AddNewItemNameTextbox;
        private ComboBox AddNewItemStatusCombobox;
        private ComboBox AddNewItemCategoryCombobox;
        private Label AddNewItemNotesLabel;
        private Label AddNewItemStatusLabel;
        private Label AddNewItemPlaceLabel;
        private Label AddNewItemSerialNumberLabel;
        private Label AddNewItemCategoryLabel;
        private Label AddNewItemNameLabel;
        private Button AddNewItemButton;
        private Label AddNewItemLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
        private ToolStripMenuItem personToolStripMenuItem;
    }
}
