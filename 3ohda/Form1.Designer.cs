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
            AddItemToolStripMenuItem = new ToolStripMenuItem();
            AddCategoryToolStripMenuItem = new ToolStripMenuItem();
            AddPersonToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { AddItemToolStripMenuItem, AddCategoryToolStripMenuItem, AddPersonToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 20);
            toolStripMenuItem1.Text = "Add new";
            // 
            // AddItemToolStripMenuItem
            // 
            AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            AddItemToolStripMenuItem.Size = new Size(122, 22);
            AddItemToolStripMenuItem.Text = "Item";
            AddItemToolStripMenuItem.Click += AddItemToolStripMenuItem_Click;
            // 
            // AddCategoryToolStripMenuItem
            // 
            AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem";
            AddCategoryToolStripMenuItem.Size = new Size(122, 22);
            AddCategoryToolStripMenuItem.Text = "Category";
            AddCategoryToolStripMenuItem.Click += AddCategoryToolStripMenuItem_Click;
            // 
            // AddPersonToolStripMenuItem
            // 
            AddPersonToolStripMenuItem.Name = "AddPersonToolStripMenuItem";
            AddPersonToolStripMenuItem.Size = new Size(122, 22);
            AddPersonToolStripMenuItem.Text = "Person";
            AddPersonToolStripMenuItem.Click += PersonToolStripMenuItem_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 631);
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
        private ToolStripMenuItem AddItemToolStripMenuItem;
        private ToolStripMenuItem AddCategoryToolStripMenuItem;
        private ToolStripMenuItem AddPersonToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
