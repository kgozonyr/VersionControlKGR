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

namespace Linq
{
    public partial class Form1 : Form
    {
        private List<Country> countries = new List<Country>();

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
        }

        private void LoadData(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split(';');

                    var countryName = sor[2];
                    var eredmeny = (from c in countries
                                          where c.Name.Equals(countryName)
                                          select c).FirstOrDefault();
                    if (eredmeny == null)
                    {
                        eredmeny = new Country()
                        {
                            ID = countries.Count,
                            Name = countryName
                        };
                        countries.Add(eredmeny);
                    }
                }
            }
        }
    }
}
