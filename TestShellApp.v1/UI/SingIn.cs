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
        UserDB users;
        string FileName;
        public SingIn()
        {
            InitializeComponent();
            var filedir = AppDomain.CurrentDomain.BaseDirectory;

            FileName = Path.Combine(filedir, "users.bin");

            if (File.Exists(FileName))
                using (var fs = File.OpenRead(FileName))
                    users = (UserDB)new BinaryFormatter().Deserialize(fs);
            else
                users = new UserDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBox1.Checked)
                {
                    users.SingUp(textBox1.Text, textBox2.Text);

                    using (var fs = File.OpenWrite(FileName))
                        new BinaryFormatter().Serialize(fs, users);
                }
                else
                {
                    users.SingIn(textBox1.Text, textBox2.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.Visible = false;
            new MainFormUSer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminSingIn().ShowDialog();
            this.Visible = false;
        }




    }
}
