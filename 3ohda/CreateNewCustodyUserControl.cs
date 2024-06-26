﻿using _3ohda.testdb;
using System.ComponentModel;
using System.Data;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace _3ohda
{
    public partial class CreateNewCustodyUserControl : UserControl
    {
        private TestdbContext connection = new();
        private List<Item> list = [];
        private BindingList<Item> bs = new();
        

        public CreateNewCustodyUserControl()
        {
            InitializeComponent();
            LoadCategoryCombobox();
            
        }

        private void RankCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RankCombobox.SelectedItem == null) return;
            NameCombobox.SelectedItem = null;
            NameCombobox.Items.Clear();
            LoadNameCombobox(RankCombobox.SelectedItem.ToString());
        }

        private void CategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCombobox.SelectedItem == null) return;
            ItemCombobox.SelectedItem = null;
            ItemCombobox.Items.Clear();
            LoadItemCombobox(((dynamic)CategoryCombobox.SelectedItem).Value);

        }

        private void ItemCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemCombobox.SelectedItem == null) return;
            int itemid = ((dynamic)ItemCombobox.SelectedItem).Value;

            Item item = connection.Items.First(x => x.Id == itemid);
            SerialNumber.Text = item.SerialNumber;
            Place.Text = item.Place;
            Notes.Text = item.Notes;
            Status.Text = connection.ItemStatuses.First(x => x.Id == item.StatusId.Value).Name;
        }

        private void AddItemToListButton_Click(object sender, EventArgs e)
        { 
            int itemid = ((dynamic)ItemCombobox.SelectedItem).Value;
            bs.Add(connection.Items.First(x => x.Id == itemid));
            
            ItemsListDataGridView.DataSource = bs;
        }

        private void LoadCategoryCombobox()
        {
            CategoryCombobox.DisplayMember = "Text";
            CategoryCombobox.ValueMember = "Value";

            var categories = connection.Categories.ToList();
            foreach (var category in categories)
            {
                CategoryCombobox.Items.Add(new { Value = category.Id, Text = category.Name });
            }
        }

        private void LoadNameCombobox(string rank)
        {
            NameCombobox.DisplayMember = "Text";
            NameCombobox.ValueMember = "Value";

            var personels = connection.Personels.Where(x => x.Rank == rank).ToList();
            foreach (var personel in personels)
            {
                NameCombobox.Items.Add(new { Value = personel.Id, Text = personel.Name });
            }
        }

        private void LoadItemCombobox(int categoryid)
        {
            ItemCombobox.DisplayMember = "Text";
            ItemCombobox.ValueMember = "Value";

            var items = connection.Items.Where(x => x.CategoryId == categoryid).ToList();
            foreach (var item in items)
            {
                ItemCombobox.Items.Add(new { Value = item.Id, Text = item.Name });
            }
        }
    }
}
