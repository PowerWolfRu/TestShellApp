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
    public partial class TestConstructor : Form
    {
        Test test;
        List<string> Question = new List<string>();
        string[] answer;
        int i = 0;
        public TestConstructor()
        {
            InitializeComponent();
            FileInfo[] infos = 
                new DirectoryInfo(Environment.CurrentDirectory).
                GetFiles("*.txt", SearchOption.AllDirectories);
            test = new Test();

            ShowCategory();
            comboBox2.DataSource = infos; 
        }


        void ShowCategory()
        {
            comboBox1.DataSource = CategoryDB.GetInstance().GetCategories();
            comboBox1.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sm = new StreamWriter(comboBox2.SelectedItem.ToString());
            for (int i = 0; i < Question.Count; i++)
            {
                sm.WriteLine(Question[i]);
            }
            sm.Close();
        }

        string GetString()
        {
            answer = Question[i].Split('^');
            i++;
            return answer[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = string.Empty;
            if (textBox4.Text != "")
            {
                a = textBox1.Text + "^" + textBox2.Text + "^" + textBox3.Text + "^" + textBox4.Text + "^";
            }
            else
            {
                a = textBox1.Text + "^" + textBox2.Text + "^" + textBox3.Text + "^" + textBox4.Text + "^";
            }
            Question.Add(a);

            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        
    }
}
