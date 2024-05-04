
using _3ohda.testdb;

namespace _3ohda
{
    public partial class AddNewItemUserControl : UserControl
    {
        public AddNewItemUserControl()
        {
            InitializeComponent();
            LoadCategoryCombobox();
            LoadStatusCombobox();
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            TestdbContext connection = new();
            Item newitem = new() 
            { 
                Name = AddNewItemNameTextbox.Text, 
                CategoryId = ((dynamic)AddNewItemCategoryCombobox.SelectedItem).Value, 
                SerialNumber = AddNewItemSerialNumberTextbox.Text, 
                Place = AddNewItemPlaceTextbox.Text, 
                StatusId = ((dynamic)AddNewItemStatusCombobox.SelectedItem).Value, 
                Notes = AddNewItemNotesTextbox.Text
            };
            connection.Items.Add(newitem);
            connection.SaveChanges();
        }

        void LoadCategoryCombobox()
        {
            AddNewItemCategoryCombobox.DisplayMember = "Text";
            AddNewItemCategoryCombobox.ValueMember = "Value";

            TestdbContext connection = new();
            var cats = connection.Categories.ToList();
            foreach (var cat in cats)
            {
               AddNewItemCategoryCombobox.Items.Add(new { Value = cat.Id, Text = cat.Name });
            }
        }

        void LoadStatusCombobox()
        {
            AddNewItemStatusCombobox.DisplayMember = "Text";
            AddNewItemStatusCombobox.ValueMember = "Value";

            TestdbContext connection = new();
            var stats = connection.ItemStatuses.ToList();
            foreach (var stat in stats)
            {
                AddNewItemStatusCombobox.Items.Add(new { Value = stat.Id, Text = stat.Name });
            } 
        }

        private void AddNewItemCategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddNewItemCategoryCombobox.SelectedIndex == 0)
            {
                AddNewItemSerialNumberLabel.Enabled = true;
                AddNewItemSerialNumberTextbox.Enabled = true;
            }
            else
            {
                AddNewItemSerialNumberLabel.Enabled = false;
                AddNewItemSerialNumberTextbox.Enabled = false;
            }
        }
    }
}
