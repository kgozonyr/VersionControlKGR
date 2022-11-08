using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance_Z686LD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LastName.Text = Resource1.LastName; // label1
            FirstName.Text = Resource1.FirstName; // label2
            Add.Text = Resource1.Add; // button1

        }
    }
}
