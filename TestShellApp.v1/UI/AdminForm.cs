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
    public partial class AdminForm : Form
    {
        TestDB db;
        public AdminForm()
        {
            InitializeComponent();
            FillFilters();
            db = new TestDB();
        }

        public void FillFilters()
        {
            comboBox1.DataSource = CategoryDB.GetInstance().GetCategories();
            comboBox1.DisplayMember = "Name";
        }

        void ShowTests()
        {
            listView1.Items.Clear();
            CategoryDB category = CategoryDB.GetInstance();
            foreach (Test test in db.allTest)
            {
                ListViewItem row = new ListViewItem(test._Test.ToString());
                row.SubItems.Add(category.GetCategoryByID(test.ID).Name);
                row.Tag = test;
                listView1.Items.Add(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayTests result = TestDB.GetInstance().GetTests();
            if (comboBox1.SelectedIndex != -1)
                result = result.GetTestsByCategory((Category)comboBox1.SelectedItem);
            ShowTests();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormTestAdd().ShowDialog();
        }
    }
}
