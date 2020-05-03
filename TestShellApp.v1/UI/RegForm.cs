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
    public partial class RegForm : Form
    {
        Person person;
        A_n_R_Class users;
        public RegForm(Person person)
        {
            InitializeComponent();

            this.person = person;
            
            users = new A_n_R_Class();

            textBox1.Text = person.Fname;
            textBox2.Text = person.Sname;
            textBox3.Text = person.Lname;
            comboBox1.DataSource = typeof(Status).GetEnumValues();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (person == null)
                person = PersonDB.GetInstance().CreatePerson(textBox1.Text, textBox2.Text, textBox3.Text);
            person.Fname = textBox1.Text;
            person.Sname = textBox2.Text;
            person.Lname = textBox3.Text;
            
            try
            {
                users.SingUpNewUser(textBox4.Text, textBox5.Text);
                
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
           

        }
    }
}
