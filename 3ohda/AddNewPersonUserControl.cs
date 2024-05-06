using _3ohda.testdb;

namespace _3ohda
{
    public partial class AddNewPersonUserControl : UserControl
    {
        public AddNewPersonUserControl()
        {
            InitializeComponent();
        }

        private void AddNewPersonButton_Click(object sender, EventArgs e)
        {
            if (AddNewPersonRankCombobox.SelectedItem is null || AddNewPersonTextbox.Text == "")
            {
                return;
            }

            TestdbContext connection = new();
            Personel newperson = new() { Name = AddNewPersonTextbox.Text, Rank = AddNewPersonRankCombobox.SelectedItem.ToString()};
            connection.Personels.Add(newperson);
            connection.SaveChanges();

            ResetInputs();
        }

        private void ResetInputs()
        {
            AddNewPersonRankCombobox.SelectedItem = null;
            AddNewPersonTextbox.Text = null;
        }
    }
}
