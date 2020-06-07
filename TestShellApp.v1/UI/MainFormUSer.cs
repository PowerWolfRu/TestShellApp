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
using System.Xml;

namespace TestShellApp.v1
{
    public partial class MainFormUSer : Form
    {
        XmlReader reader;
        DirectoryInfo TestDir = new DirectoryInfo("Tests");
        public MainFormUSer()
        {
            InitializeComponent();
           

            comboBox1.Items.AddRange(TestDir.GetDirectories()); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeLable.Text = "Тема теста: ";
            DirectoryInfo TestDir = new DirectoryInfo("Tests\\" + comboBox1.Text);
            listBox1.Items.Clear();

            foreach(FileInfo file in TestDir.GetFiles())
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormUSer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
                this.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = new XmlTextReader("Tests\\" + comboBox1.Text + "\\" + listBox1.Text + ".xml");

            do reader.Read();
            while (reader.Name != "Theme");

            reader.Read();

            ThemeLable.Text = "Тема теста: " + reader.Value;

            reader.Read();

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Введите имя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string xmlpath = "Tests\\" + comboBox1.Text + "\\" + listBox1.Text + ".xml";
                //TestForm testForm = new TestForm(xmlpath, textBox1.Text, ThemeLable.Text);
                //testForm.Show();
                new TestForm(xmlpath, textBox1.Text, ThemeLable.Text).Show();
            }
        }
    }
}
