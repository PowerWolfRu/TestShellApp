using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShellApp.v1.UI
{
    public partial class AdminFormInfoAdd : Form
    {
        Admin admin; 
        public AdminFormInfoAdd(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

            textBox1.Text = admin.LastName;
            textBox2.Text = admin.FirstName;
            textBox3.Text = admin.SecondName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.LastName = textBox1.Text;
            admin.FirstName = textBox2.Text;
            admin.SecondName = textBox3.Text;
            Close();
        }
    }
}
