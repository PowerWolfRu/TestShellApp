﻿using System;
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
    public partial class MainFormUSer : Form
    {
        StreamReader reader;
        public MainFormUSer()
        {
            InitializeComponent();
        }

        void Tests()
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new TestForm().ShowDialog();
        }
    }
}
