﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void کالاهاToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 kalaForm = new Form2();
            kalaForm.Show();
        }

        private void مدیریتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHelper.form1 = this;
        }
    }
}
