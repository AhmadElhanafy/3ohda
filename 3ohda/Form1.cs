using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Text;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace _3ohda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategoryCombobox();
            LoadStatusCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";

            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                string query = "select Name, Type, NameOfTaker, DateTaken, PlaceTaken,Quantity - QuantityReturned as RemainningQuantity from items where Returned = 0";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, con);
                mySqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AddNewPersonRankCombobox.SelectedItem is null || textBox1.Text == "")
            {
                return;
            }

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO personel (`Rank`, Name) VALUES(@rank, @name)";
            comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
            comm.Parameters.AddWithValue("@rank", AddNewPersonRankCombobox.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();

            AddNewPersonRankCombobox.SelectedItem = null;
            textBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AddNewCategoryTextBox.Text == "")
            {
                return;
            }

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO category (Name) VALUES(@name)";
            comm.Parameters.AddWithValue("@name", AddNewCategoryTextBox.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();

            AddNewCategoryTextBox.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO item (Name, CategoryID, SerialNumber, Place, StatusID, Notes) VALUES(@name, @categoryID, @serialNumber, @place, @statusID, @notes)";
            comm.Parameters.AddWithValue("@name", AddNewItemNameTextbox.Text.ToString());
            comm.Parameters.AddWithValue("@categoryID", (AddNewItemCategoryCombobox.SelectedItem as dynamic).Value);
            comm.Parameters.AddWithValue("@serialNumber", AddNewCategoryTextBox.Text.ToString());
            comm.Parameters.AddWithValue("@place", AddNewItemPlaceTextbox.Text.ToString());
            comm.Parameters.AddWithValue("@statusID", (AddNewItemStatusCombobox.SelectedItem as dynamic).Value);
            comm.Parameters.AddWithValue("@notes", AddNewItemNotesTextbox.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}