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
using Check;

namespace TestShellApp.v1
{
    public partial class FormTestAdd : Form
    {
        XmlTextWriter TestWriter;
        public FormTestAdd()
        {
            InitializeComponent();
            DirectoryInfo TestDir = new DirectoryInfo("Tests");



            if (!TestDir.Exists)
                TestDir.Create();
            CategoryBox.Items.AddRange(TestDir.GetDirectories());
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(CategoryBox.Text != "" && ThemeBox.Text != "" && NameBox.Text != "")
            {
                try
                {
                    TestWriter = new XmlTextWriter
                        ("Tests\\" + CategoryBox.Text + "\\" + NameBox.Text + ".xml", Encoding.UTF8); 
                }
                catch(DirectoryNotFoundException)
                {
                    Directory.CreateDirectory("Tests\\" + CategoryBox.Text);
                    TestWriter = new XmlTextWriter
                        ("Tests\\" + CategoryBox.Text + "\\" + NameBox.Text + ".xml", Encoding.UTF8);   
                }


                TestWriter.Formatting = Formatting.Indented;

                TestWriter.WriteStartDocument();
                TestWriter.WriteStartElement("Test");

                TestWriter.WriteStartElement("Theme");
                TestWriter.WriteString(ThemeBox.Text);
                TestWriter.WriteEndElement();

                TestWriter.WriteStartElement("Questions");
                TestWriter.WriteStartAttribute("Nums");
                TestWriter.WriteString(NumQuestUpDwn.Value.ToString());
                TestWriter.WriteEndAttribute();

                for(int i = 1; i <= NumQuestUpDwn.Value; i++)
                {
                    TestConstructor constructor = new TestConstructor(i, TestWriter);
                    constructor.ShowDialog() ;
                }

                TestWriter.WriteEndElement();
                TestWriter.WriteEndElement();
                TestWriter.WriteEndDocument();

                TestWriter.Close();

                MessageBox.Show("Тест успешно создан", "Выход");

            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание!");
            }
        }
    }
}
