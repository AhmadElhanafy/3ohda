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
        private UserControl lastUsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            addNewItemUserControl1.Enabled = true;
            addNewItemUserControl1.Visible = true;
            lastUsed = addNewItemUserControl1;
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            addNewCategoryUserControl1.Enabled = true;
            addNewCategoryUserControl1.Visible = true;
            lastUsed = addNewCategoryUserControl1;
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            addNewPersonUserControl1.Enabled = true;
            addNewPersonUserControl1.Visible = true;
            lastUsed = addNewPersonUserControl1;
        }

        private void SwitchingPanels()
        {
            if (lastUsed != null)
            { 
                lastUsed.Visible = false;
                lastUsed.Enabled = false;
            }
        }
    }
}