namespace _3ohda
{
    partial class CreateNewCustodyUserControl
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
            RankLabel = new Label();
            RankCombobox = new ComboBox();
            NameCombobox = new ComboBox();
            NameLabel = new Label();
            SelectItemsLabel = new Label();
            ItemCombobox = new ComboBox();
            ItemLabel = new Label();
            CategoryCombobox = new ComboBox();
            CategoryLabel = new Label();
            Status = new Label();
            StatusLabel = new Label();
            PlaceLabel = new Label();
            Place = new Label();
            SerialNumberLabel = new Label();
            SerialNumber = new Label();
            NotesLabel = new Label();
            Notes = new Label();
            ItemsListDataGridView = new DataGridView();
            CreateCustodyButton = new Button();
            AddItemToListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ItemsListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // RankLabel
            // 
            RankLabel.AutoSize = true;
            RankLabel.Location = new Point(79, 60);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(33, 15);
            RankLabel.TabIndex = 0;
            RankLabel.Text = "Rank";
            // 
            // RankCombobox
            // 
            RankCombobox.FormattingEnabled = true;
            RankCombobox.Items.AddRange(new object[] { "ضابط صف", "ملازم", "ملازم اول", "نقيب", "رائد", "مقدم", "عقيد", "عميد", "لواء", "فريق", "فريق اول", "مشير" });
            RankCombobox.Location = new Point(141, 57);
            RankCombobox.Name = "RankCombobox";
            RankCombobox.Size = new Size(121, 23);
            RankCombobox.TabIndex = 1;
            RankCombobox.SelectedIndexChanged += RankCombobox_SelectedIndexChanged;
            // 
            // NameCombobox
            // 
            NameCombobox.FormattingEnabled = true;
            NameCombobox.Location = new Point(436, 57);
            NameCombobox.Name = "NameCombobox";
            NameCombobox.Size = new Size(121, 23);
            NameCombobox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(374, 60);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // SelectItemsLabel
            // 
            SelectItemsLabel.AutoSize = true;
            SelectItemsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectItemsLabel.Location = new Point(32, 94);
            SelectItemsLabel.Name = "SelectItemsLabel";
            SelectItemsLabel.Size = new Size(129, 30);
            SelectItemsLabel.TabIndex = 4;
            SelectItemsLabel.Text = "Select items:";
            // 
            // ItemCombobox
            // 
            ItemCombobox.FormattingEnabled = true;
            ItemCombobox.Location = new Point(436, 138);
            ItemCombobox.Name = "ItemCombobox";
            ItemCombobox.Size = new Size(121, 23);
            ItemCombobox.TabIndex = 8;
            ItemCombobox.SelectedIndexChanged += ItemCombobox_SelectedIndexChanged;
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Location = new Point(374, 141);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new Size(31, 15);
            ItemLabel.TabIndex = 7;
            ItemLabel.Text = "Item";
            // 
            // CategoryCombobox
            // 
            CategoryCombobox.FormattingEnabled = true;
            CategoryCombobox.Location = new Point(141, 138);
            CategoryCombobox.Name = "CategoryCombobox";
            CategoryCombobox.Size = new Size(121, 23);
            CategoryCombobox.TabIndex = 6;
            CategoryCombobox.SelectedIndexChanged += CategoryCombobox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(79, 141);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(55, 15);
            CategoryLabel.TabIndex = 5;
            CategoryLabel.Text = "Category";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(166, 190);
            Status.Name = "Status";
            Status.Size = new Size(39, 15);
            Status.TabIndex = 9;
            Status.Text = "Status";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(79, 190);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "Status";
            // 
            // PlaceLabel
            // 
            PlaceLabel.AutoSize = true;
            PlaceLabel.Location = new Point(374, 190);
            PlaceLabel.Name = "PlaceLabel";
            PlaceLabel.Size = new Size(35, 15);
            PlaceLabel.TabIndex = 12;
            PlaceLabel.Text = "Place";
            // 
            // Place
            // 
            Place.AutoSize = true;
            Place.Location = new Point(436, 190);
            Place.Name = "Place";
            Place.Size = new Size(35, 15);
            Place.TabIndex = 11;
            Place.Text = "Place";
            // 
            // SerialNumberLabel
            // 
            SerialNumberLabel.AutoSize = true;
            SerialNumberLabel.Location = new Point(79, 229);
            SerialNumberLabel.Name = "SerialNumberLabel";
            SerialNumberLabel.Size = new Size(82, 15);
            SerialNumberLabel.TabIndex = 14;
            SerialNumberLabel.Text = "Serial Number";
            // 
            // SerialNumber
            // 
            SerialNumber.AutoSize = true;
            SerialNumber.Location = new Point(167, 229);
            SerialNumber.Name = "SerialNumber";
            SerialNumber.Size = new Size(82, 15);
            SerialNumber.TabIndex = 13;
            SerialNumber.Text = "Serial Number";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(374, 229);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(38, 15);
            NotesLabel.TabIndex = 16;
            NotesLabel.Text = "Notes";
            // 
            // Notes
            // 
            Notes.AutoSize = true;
            Notes.Location = new Point(436, 229);
            Notes.Name = "Notes";
            Notes.Size = new Size(38, 15);
            Notes.TabIndex = 15;
            Notes.Text = "Notes";
            // 
            // ItemsListDataGridView
            // 
            ItemsListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsListDataGridView.Location = new Point(36, 355);
            ItemsListDataGridView.Name = "ItemsListDataGridView";
            ItemsListDataGridView.Size = new Size(725, 177);
            ItemsListDataGridView.TabIndex = 17;
            // 
            // CreateCustodyButton
            // 
            CreateCustodyButton.Location = new Point(351, 538);
            CreateCustodyButton.Name = "CreateCustodyButton";
            CreateCustodyButton.Size = new Size(75, 23);
            CreateCustodyButton.TabIndex = 18;
            CreateCustodyButton.Text = "Confirm";
            CreateCustodyButton.UseVisualStyleBackColor = true;
            // 
            // AddItemToListButton
            // 
            AddItemToListButton.Location = new Point(332, 289);
            AddItemToListButton.Name = "AddItemToListButton";
            AddItemToListButton.Size = new Size(107, 23);
            AddItemToListButton.TabIndex = 19;
            AddItemToListButton.Text = "Add Item To List";
            AddItemToListButton.UseVisualStyleBackColor = true;
            AddItemToListButton.Click += AddItemToListButton_Click;
            // 
            // CreateNewCustodyUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddItemToListButton);
            Controls.Add(CreateCustodyButton);
            Controls.Add(ItemsListDataGridView);
            Controls.Add(NotesLabel);
            Controls.Add(Notes);
            Controls.Add(SerialNumberLabel);
            Controls.Add(SerialNumber);
            Controls.Add(PlaceLabel);
            Controls.Add(Place);
            Controls.Add(StatusLabel);
            Controls.Add(Status);
            Controls.Add(ItemCombobox);
            Controls.Add(ItemLabel);
            Controls.Add(CategoryCombobox);
            Controls.Add(CategoryLabel);
            Controls.Add(SelectItemsLabel);
            Controls.Add(NameCombobox);
            Controls.Add(NameLabel);
            Controls.Add(RankCombobox);
            Controls.Add(RankLabel);
            Name = "CreateNewCustodyUserControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)ItemsListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RankLabel;
        private ComboBox RankCombobox;
        private ComboBox NameCombobox;
        private Label NameLabel;
        private Label SelectItemsLabel;
        private ComboBox ItemCombobox;
        private Label ItemLabel;
        private ComboBox CategoryCombobox;
        private Label CategoryLabel;
        private Label Status;
        private Label StatusLabel;
        private Label PlaceLabel;
        private Label Place;
        private Label SerialNumberLabel;
        private Label SerialNumber;
        private Label NotesLabel;
        private Label Notes;
        private DataGridView ItemsListDataGridView;
        private Button CreateCustodyButton;
        private Button AddItemToListButton;
    }
}
