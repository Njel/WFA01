﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();
            Boolean bResult = oEmployee.Login(txtName.Text, txtPassword.Text);
            if (bResult == true)
            {
                MessageBox.Show("Your security level is: " + oEmployee.SecurityLevel);
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
