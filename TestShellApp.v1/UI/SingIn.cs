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
    public partial class SingIn : Form
    {
        A_n_R_Class users;
        string filename;
        public SingIn()
        {
            InitializeComponent();
            

            var filedir = AppDomain.CurrentDomain.BaseDirectory;

            filename = Path.Combine(filedir, "user.bin");

            if (File.Exists(filename))
                using (var fs = File.OpenRead(filename))
                    users = (A_n_R_Class)new BinaryFormatter().Deserialize(fs);
            else
                users = new A_n_R_Class();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                users.SingIn(textBox1.Text, textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            new MainFormUSer().Show();
            this.Hide();
        }
    }
}
