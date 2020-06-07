using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mark;

namespace TestShellApp.v1
{
    public partial class FinalTestForm : Form
    {
        double Mark;
        public FinalTestForm(string PersonName, string Theme, int NumbersOfQuest, int RightAnswers)
        {
            InitializeComponent();
            label1.Text += PersonName;
            label2.Text += Theme;
            label3.Text += NumbersOfQuest.ToString();
            label4.Text += RightAnswers.ToString();


            Mark = mark.MarkClass.Mark(NumbersOfQuest, RightAnswers);
            label5.Text += Mark.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
