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
    public partial class TestConstructor : Form
    {
        XmlTextWriter TestWriter;
        int count;
        public TestConstructor(int c, XmlTextWriter writer)
        {
            InitializeComponent();
            TestWriter = writer;
            count = c;

            this.Text = "Создание вопроса №" + count;


        }

        private void TestConstructor_Load(object sender, EventArgs e)
        {

        }

        private void TestConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void NextQuest_Click(object sender, EventArgs e)
        {
            if (QuestBox.Text != "" && AnswBox1.Text != "" && AnswBox2.Text != ""
                && AnswBox3.Text != "" && AnswBox4.Text != "" && RightAnswBox.Text != "")
            {
                if (RightAnswBox.Text == AnswBox1.Text || RightAnswBox.Text == AnswBox2.Text ||
                    RightAnswBox.Text == AnswBox3.Text || RightAnswBox.Text == AnswBox4.Text)
                {
                    TestWriter.WriteStartElement("quest" + count);

                    TestWriter.WriteStartAttribute("text");
                    TestWriter.WriteString(QuestBox.Text);
                    TestWriter.WriteEndAttribute();

                    TestWriter.WriteStartAttribute("right");
                    TestWriter.WriteString(RightAnswBox.Text);
                    TestWriter.WriteEndAttribute();

                    TestWriter.WriteStartElement("answers");
                    TestWriter.WriteString(AnswBox1.Text + "|" + AnswBox2.Text + "|" + AnswBox3.Text + "|" + AnswBox4.Text);
                    TestWriter.WriteEndElement();

                    TestWriter.WriteEndElement();

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Правильный ответ не совпадает с одним вариантов ответа!\n\nСкопируйте правильный овтет в соответсвующее поле");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание");
            }
        }
    }
}
