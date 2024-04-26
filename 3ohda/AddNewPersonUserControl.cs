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
    public partial class AddNewPersonUserControl : UserControl
    {
        public AddNewPersonUserControl()
        {
            InitializeComponent();
        }

        private void AddNewPersonButton_Click(object sender, EventArgs e)
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

    }
}
