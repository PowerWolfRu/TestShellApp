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
    public partial class TestForm : Form
    {
        Int32 questionCount;
        Int32 correctAnswer;
        Int32 wrongAnswer;
        String[] WrongAnswer;
        Int32 numCorrectAnswer;
        Int32 selectAnswer;
        StreamReader reader;
        public TestForm()
        {
            InitializeComponent();
            Text = "Тест";
            CenterToScreen();
            AutoSize = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            button2.Text = "Перемешать вопросы";
            button1.AutoSize = true;
            button3.AutoSize = true;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button3.Text = "Выход";

            radioButton1.CheckedChanged += new EventHandler(ChangeSwitch);
            radioButton2.CheckedChanged += new EventHandler(ChangeSwitch);
            radioButton3.CheckedChanged += new EventHandler(ChangeSwitch);

        }

        void StartTest()
        {
            var encoding = System.Text.Encoding.GetEncoding(1251);
            try
            {
                reader = new StreamReader(Directory.GetCurrentDirectory() + listView1. )
            }
        }

        void ChangeSwitch(Object sender, EventArgs e)
        {
            button1.Enabled = true; button1.Focus();
            RadioButton _switch = (RadioButton)sender;
            var temp = _switch.Name;
            selectAnswer = Int32.Parse(temp.Substring(11));
        }
    }
}
