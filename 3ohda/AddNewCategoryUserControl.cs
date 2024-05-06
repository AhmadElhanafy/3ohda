
using _3ohda.testdb;

namespace _3ohda
{
    public partial class AddNewCategoryUserControl : UserControl
    {
        public AddNewCategoryUserControl()
        {
            InitializeComponent();
        }

        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            if (AddNewCategoryTextBox.Text == "")
            {
                return;
            }

            TestdbContext connection = new();
            Category newcategory = new() { Name = AddNewCategoryTextBox.Text.ToString() };
            connection.Categories.Add(newcategory);
            connection.SaveChanges();

            ResetInputs();
        }

        private void ResetInputs()
        {
            AddNewCategoryTextBox.Text = null;
        }
    }
}
