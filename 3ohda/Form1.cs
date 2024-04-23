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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
            comm.CommandText = "INSERT INTO testdb.personel (`Rank`, Name) VALUES(@rank, @name)";
            comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
            comm.Parameters.AddWithValue("@rank", comboBox1.SelectedItem.ToString());
            comm.ExecuteNonQuery();
            conn.Close();

            comboBox1.SelectedItem = null;
            textBox1.Text = null;
        }
    }
}