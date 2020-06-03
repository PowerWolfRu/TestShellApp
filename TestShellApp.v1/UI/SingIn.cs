using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShellApp.v1
{
    public partial class SingIn : Form
    {
        A_n_R_Class users;
        UserDB Db;
        User user;
        
        public SingIn()
        {
            InitializeComponent();
            users = new A_n_R_Class();
            Db = new UserDB();
            user = new User();

            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            new RegForm(Db.AddUser()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db.LoadJson();
            try
            {
                
                if (users.SingIn(textBox1.Text, textBox2.Text, Status.Пользователь))
                {
                    new MainFormUSer().Show();
                }
                else if (users.SingIn(textBox1.Text, textBox2.Text, Status.Администратор))
                {
                    new AdminForm().Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminSingIn().ShowDialog();
            this.Hide();
        }
    }
}
