using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShellApp.v1
{
    public partial class FormTestAdd : Form
    {
        public FormTestAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sm = new StreamWriter(textBox1.Text);
            sm.Close();
            MessageBox.Show("Файл успешно создан");
            new TestConstructor().ShowDialog();
            this.Hide();
        }
    }
}
