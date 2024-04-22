using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

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
                string query = "select * from items where Quantity - QuantityReturned > 0";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, con);
                mySqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
