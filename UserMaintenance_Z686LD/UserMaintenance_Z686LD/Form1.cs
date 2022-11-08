﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance_Z686LD.Entities;

namespace UserMaintenance_Z686LD
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
               
	
    public Form1()
        {
            InitializeComponent();
            FullName.Text = Resource1.FullName; // label1
            Add.Text = Resource1.Add; // button1

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
              FullName = txtFullName.Text
                };
            users.Add(u);

        }
    }
}
