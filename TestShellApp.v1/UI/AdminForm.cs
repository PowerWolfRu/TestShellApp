using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestShellApp.v1.UI;

namespace TestShellApp.v1
{
    public partial class AdminForm : Form
    {
        AdminDB db;
        public AdminForm()
        {
            InitializeComponent();
            db = new AdminDB();
            ShowAdminInfo();
        }

        void ShowAdminInfo()
        {
            textBox1.Text = db.admin_info.LastName;
            textBox2.Text = db.admin_info.FirstName;
            textBox3.Text = db.admin_info.SecondName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormTestAdd().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FormTestAdd().Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new AdminFormInfoAdd(db.admin_info).ShowDialog();
            ShowAdminInfo();
            db.SaveAdmin();
        }
    }
}
