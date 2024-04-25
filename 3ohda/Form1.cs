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
            if (comboBox1.SelectedItem is null || textBox1.Text == "")
            {
                return;
            }

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO personel (`Rank`, Name) VALUES(@rank, @name)";
            comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
            comm.Parameters.AddWithValue("@rank", comboBox1.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();

            comboBox1.SelectedItem = null;
            textBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                return;
            }

            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO category (Name) VALUES(@name)";
            comm.Parameters.AddWithValue("@name", textBox2.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();

            textBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            MySqlConnection conn = new(constring);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO item (Name, CategoryID, SerialNumber, Place, StatusID, Notes) VALUES(@name, @categoryID, @serialNumber, @place, @statusID, @notes)";
            comm.Parameters.AddWithValue("@name", textBox3.Text.ToString());
            ComboboxValue tmpComboboxValue = comboBox1.SelectedItem as ComboboxValue;
            comm.Parameters.AddWithValue("@categoryID", tmpComboboxValue.Id.ToString());
            comm.Parameters.AddWithValue("@serialNumber", textBox2.Text.ToString());
            comm.Parameters.AddWithValue("@place", textBox4.Text.ToString());
            tmpComboboxValue = (ComboboxValue)comboBox3.SelectedItem;
            comm.Parameters.AddWithValue("@statusID", tmpComboboxValue.Id.ToString());
            comm.Parameters.AddWithValue("@notes", textBox5.Text.ToString());
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label6.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                label6.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        void LoadCategoryCombobox()
        {
            string constring = "Server=localhost; database=testdb; uid=root; pwd=root";
            DataTable linkcat = new DataTable("category");
            using (MySqlConnection sqlConn = new(constring))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT Name FROM category", sqlConn))
                {
                    da.Fill(linkcat);
                }
            }
            foreach (DataRow da in linkcat.Rows)
            {
                comboBox2.Items.Add(da[0].ToString());
            }   
        }

        void LoadStatusCombobox()
        {
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

                comboBox3.Items.Add(new ComboboxValue((int)da[0], da[1].ToString()));
            }
        }
    }
}