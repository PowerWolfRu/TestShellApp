using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShellApp.v1
{
    public partial class RegForm : Form
    {
        User users;
        UserDB db;
        
        public RegForm(User user)
        {
            InitializeComponent();
            db = new UserDB();
            this.users = user;
            textBox4.Text = user.Login;
            textBox5.Text = user.Password;
            comboBox1.DataSource = typeof(Status).GetEnumValues(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                users.Login = textBox4.Text;
                users.Password = textBox5.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.SaveUser();
            this.Close();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
