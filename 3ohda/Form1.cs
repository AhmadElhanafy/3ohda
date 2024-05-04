
namespace _3ohda
{
    public partial class Form1 : Form
    {
        private UserControl? lastUsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            addNewItemUserControl1.Enabled = true;
            addNewItemUserControl1.Visible = true;
            lastUsed = addNewItemUserControl1;
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            addNewCategoryUserControl1.Enabled = true;
            addNewCategoryUserControl1.Visible = true;
            lastUsed = addNewCategoryUserControl1;
        }

        private void PersonToolStripMenuItem_Click(object sender, EventArgs e)
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