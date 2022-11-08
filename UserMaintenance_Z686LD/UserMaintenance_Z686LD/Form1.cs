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
            fajlbaIras.Text = Resource1.SaveToFile; // button2

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

        private void fajlbaIras_Click(object sender, EventArgs e)
        {
            SaveFileDialog mentésdialog = new SaveFileDialog();
            if (mentésdialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter steamwriter = new StreamWriter(mentésdialog.FileName))
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        steamwriter.WriteLine(users[i].ID + "," + users[i].FullName);
                    }
                }
            }
        }
    }
}
