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
    public partial class AdminSingIn : Form
    {
        public AdminSingIn()
        {
            InitializeComponent();
        }
        string log = "log";
        string pass = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == log && textBox2.Text == pass)
            {
                new AdminForm().Show();
            }
        }
    }
}
