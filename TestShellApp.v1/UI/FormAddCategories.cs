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
    public partial class FormAddCategories : Form
    {
        Category category;
        public FormAddCategories(Category category)
        {
            InitializeComponent();
            this.category = category;
            textBox1.Text = category.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            category.Name = textBox1.Text;
            Close();
        }
    }
}
