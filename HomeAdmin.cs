﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new EmployeeManagement().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new ReportForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginScreen().Show();
        }
    }
}
