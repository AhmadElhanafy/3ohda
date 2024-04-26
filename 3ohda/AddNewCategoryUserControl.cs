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
    }
}
