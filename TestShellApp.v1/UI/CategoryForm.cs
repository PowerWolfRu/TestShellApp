using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShellApp.v1
{
    public partial class CategoryForm : Form
    {
        CategoryDB db;
        public CategoryForm()
        {
            InitializeComponent();
            db = new CategoryDB();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddCategories(db.AddCategory()).ShowDialog();
            db.SaveCategories();
            ShowCategories();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Category category = (Category)listView1.SelectedItems[0].Tag;
            new FormAddCategories(category).ShowDialog();
            db.SaveCategories();
            ShowCategories();
        }

        void ShowCategories()
        {
            listView1.Items.Clear();
            foreach(Category category in db.allCategories)
            {
                ListViewItem row = new ListViewItem(category.Name);
                row.Tag = category;
                listView1.Items.Add(row);

            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Category category = (Category)listView1.SelectedItems[0].Tag;
            if (MessageBox.Show("Точно удалить категорию?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.RemoveCategory(category);
                ShowCategories();
            }
        }
    }
}
