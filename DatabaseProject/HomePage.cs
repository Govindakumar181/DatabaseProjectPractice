﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {


            lblWelcomeTitle.Text = "Welcome " + SignIn.name;

            txtNameUpdate.Text = SignIn.name;
            txtEmailUpdate.Text = SignIn.email;
            txtPasswordUpdate.Text = SignIn.password;
            txtCountryUpdate.Text = SignIn.country;
            
        }
    }
}
