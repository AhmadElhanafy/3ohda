using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO item (Name, CategoryID, SerialNumber, Place, StatusID, Notes) VALUES(@name, @categoryID, @serialNumber, @place, @statusID, @notes)";
            comm.Parameters.AddWithValue("@name", AddNewItemNameTextbox.Text.ToString());
            comm.Parameters.AddWithValue("@categoryID", (AddNewItemCategoryCombobox.SelectedItem as dynamic).Value);
            comm.Parameters.AddWithValue("@serialNumber", AddNewItemSerialNumberTextbox.Text);
            comm.Parameters.AddWithValue("@place", AddNewItemPlaceTextbox.Text.ToString());
            comm.Parameters.AddWithValue("@statusID", (AddNewItemStatusCombobox.SelectedItem as dynamic).Value);
            comm.Parameters.AddWithValue("@notes", AddNewItemNotesTextbox.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();
        }

        void LoadCategoryCombobox()
        {
            AddNewItemCategoryCombobox.DisplayMember = "Text";
            AddNewItemCategoryCombobox.ValueMember = "Value";

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            DataTable linkcat = new DataTable("category");
            using (MySqlConnection sqlConn = new(constring))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM category", sqlConn))
                {
                    da.Fill(linkcat);
                }
            }

            var items = Array.Empty<object>();
            foreach (DataRow da in linkcat.Rows)
            {

                AddNewItemCategoryCombobox.Items.Add(new { Value = da[0].ToString(), Text = da[1].ToString() });
            }
        }

        void LoadStatusCombobox()
        {
            AddNewItemStatusCombobox.DisplayMember = "Text";
            AddNewItemStatusCombobox.ValueMember = "Value";

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            DataTable linkcat = new DataTable("item_status");
            using (MySqlConnection sqlConn = new(constring))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM item_status", sqlConn))
                {
                    da.Fill(linkcat);
                }
            }
            foreach (DataRow da in linkcat.Rows)
            {
                AddNewItemStatusCombobox.Items.Add(new { Value = da[0].ToString(), Text = da[1].ToString() });
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
