namespace _3ohda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripMenuItem1 = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            personToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            addNewItemUserControl1 = new AddNewItemUserControl();
            addNewPersonUserControl1 = new AddNewPersonUserControl();
            addNewCategoryUserControl1 = new AddNewCategoryUserControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, addCategoryToolStripMenuItem, personToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 20);
            toolStripMenuItem1.Text = "Add new";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(122, 22);
            addItemToolStripMenuItem.Text = "Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.Size = new Size(122, 22);
            addCategoryToolStripMenuItem.Text = "Category";
            addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
            // 
            // personToolStripMenuItem
            // 
            personToolStripMenuItem.Name = "personToolStripMenuItem";
            personToolStripMenuItem.Size = new Size(122, 22);
            personToolStripMenuItem.Text = "Person";
            personToolStripMenuItem.Click += personToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewItemUserControl1
            // 
            addNewItemUserControl1.Enabled = false;
            addNewItemUserControl1.Location = new Point(0, 27);
            addNewItemUserControl1.Name = "addNewItemUserControl1";
            addNewItemUserControl1.Size = new Size(800, 600);
            addNewItemUserControl1.TabIndex = 7;
            addNewItemUserControl1.Visible = false;
            // 
            // addNewPersonUserControl1
            // 
            addNewPersonUserControl1.Enabled = false;
            addNewPersonUserControl1.Location = new Point(0, 27);
            addNewPersonUserControl1.Name = "addNewPersonUserControl1";
            addNewPersonUserControl1.Size = new Size(800, 600);
            addNewPersonUserControl1.TabIndex = 8;
            addNewPersonUserControl1.Visible = false;
            // 
            // addNewCategoryUserControl1
            // 
            addNewCategoryUserControl1.Enabled = false;
            addNewCategoryUserControl1.Location = new Point(0, 27);
            addNewCategoryUserControl1.Name = "addNewCategoryUserControl1";
            addNewCategoryUserControl1.Size = new Size(800, 600);
            addNewCategoryUserControl1.TabIndex = 9;
            addNewCategoryUserControl1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 631);
            Controls.Add(addNewCategoryUserControl1);
            Controls.Add(addNewPersonUserControl1);
            Controls.Add(addNewItemUserControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
        private ToolStripMenuItem personToolStripMenuItem;
        private MenuStrip menuStrip1;
        private AddNewItemUserControl addNewItemUserControl1;
        private AddNewPersonUserControl addNewPersonUserControl1;
        private AddNewCategoryUserControl addNewCategoryUserControl1;
    }
}
