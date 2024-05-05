
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
            AddNewItemUserControl addNewItemUserControl = new()
            {
                Location = new Point(0, 27),
                Name = "addNewItemUserControl1",
                Size = new Size(800, 600)
            };
            Controls.Add(addNewItemUserControl);
            lastUsed = addNewItemUserControl;
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            AddNewCategoryUserControl addNewCategoryUserControl = new()
            {
                Location = new Point(0, 27),
                Name = "addNewCategoryUserControl1",
                Size = new Size(800, 600)
            };
            Controls.Add(addNewCategoryUserControl);
            lastUsed = addNewCategoryUserControl;
        }

        private void PersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchingPanels();
            AddNewPersonUserControl addNewPersonUserControl = new()
            {
                Location = new Point(0, 27),
                Name = "addNewPersonUserControl1",
                Size = new Size(800, 600)
            };
            Controls.Add(addNewPersonUserControl);
            lastUsed = addNewPersonUserControl;
        }

        private void SwitchingPanels()
        {
            lastUsed?.Dispose();
        }
    }
}