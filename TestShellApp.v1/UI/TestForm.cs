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
using System.Xml.Serialization;

namespace TestShellApp.v1
{
    public partial class TestForm : Form
    {
        XmlReader xmlReader;
        string PersonName;
        string Theme;
        int nQuest;
        int RightAnsw;
        int position = 0;

        string quest;
        string[] answ = new string[4];
        string right;
        bool righting;
        public TestForm(string TestPath, string personName, string theme)
        {
            InitializeComponent();
            PersonName = personName;
            Theme = theme;

            MessageBox.Show("Для начала тестирования нажмите \"OK\"", "Тест");

            xmlReader = new XmlTextReader(TestPath);
            xmlReader.Read();

            ReadNumbers();
            LoadQuest();
            ShowQuest();
        }

        void ReadNumbers()
        {
            do xmlReader.Read();
            while (xmlReader.Name != "Questions");

            nQuest = Convert.ToInt32(xmlReader.GetAttribute("Nums"));
            xmlReader.Read();
        }

        void LoadQuest()
        {
            position++;
            if (position > nQuest)
                Result();
            else
            {
                do xmlReader.Read();
                while (xmlReader.Name != "quest" + position);

                if(xmlReader.Name == "quest" + position)
                {
                    quest = xmlReader.GetAttribute("text");
                    right = xmlReader.GetAttribute("right");
                    xmlReader.Read();

                    do xmlReader.Read();
                    while (xmlReader.Name != "answers");

                    xmlReader.Read();

                    answ = xmlReader.Value.Split('|');
                }
            }    
        }

        void Result()
        {
            MessageBox.Show("Тестирование окончено!", "Тестирование");
            FinalTestForm FTF = new FinalTestForm(PersonName, Theme, nQuest, RightAnsw);
            this.Dispose();
            FTF.ShowDialog();
        }

        void ShowQuest()
        {
            label1.Text = quest;

            radioButton1.Text = answ[0];
            radioButton2.Text = answ[1];
            radioButton3.Text = answ[2];
            radioButton4.Text = answ[3];

            button2.Enabled = false;
        }

        void Checked()
        {
            if (righting == true)
                RightAnsw++;
        }



        private void Test_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checked();
            LoadQuest();
            ShowQuest(); 
            righting = false; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            righting = false;

            if (radioButton1.Checked)
            {
                if (radioButton1.Text == right)
                    righting = true;
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == right)
                    righting = true;
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == right)
                    righting = true;
            }
            if (radioButton4.Checked)
            {
                if (radioButton4.Text == right)
                    righting = true;
            }

            button2.Enabled = true;
        }
    }
}
