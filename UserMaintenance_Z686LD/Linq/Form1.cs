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
        private List<Ramen> ramens = new List<Ramen>();
        private List<Brand> brands = new List<Brand>();

        public Form1()
        {
            InitializeComponent();
            LoadData("ramen.csv");
            GetCountries();
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
                    var markaName = sor[0];
                    var aktorszag = AddCountry(countryName);
                    var aktmarka = AddBrand(markaName);

                    Ramen r = new Ramen
                    {
                        ID = ramens.Count,
                        Brand = aktmarka,
                        Name = sor[1],
                        CountryFK = aktorszag.ID,
                        Country = aktorszag,
                        Rating = Convert.ToDouble(sor[3])
                    };
                    ramens.Add(r);
                }

            }
        }

        private Country AddCountry(string countryName)
        {
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
            return eredmeny;
        }

        private Brand AddBrand(string marka)
        {
            var eredmeny = (from c in brands
                            where c.Name.Equals(marka)
                            select c).FirstOrDefault();
            if (eredmeny == null)
            {
                eredmeny = new Brand()
                {
                    ID = brands.Count,
                    Name = marka
                };
                brands.Add(eredmeny);
            }
            return eredmeny;
        }

        void GetCountries()
        {
            var eredmeny = from c in countries 
                           where c.Name.ToLower().Contains(textBox1.Text.ToLower()) 
                           orderby c.Name 
                           select c;
            listBox1.DataSource = eredmeny.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetCountries();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country kivalasztottorszag = (Country)listBox1.SelectedItem;
            if (kivalasztottorszag==null)
            {
                return;
            }

            var eredmeny = from r in ramens 
                           where r.CountryFK == kivalasztottorszag.ID 
                           select r;
            var eredmeny2 = from b in eredmeny
                            group b.Rating by b.Brand.Name
                            into f
                            select new
                            {
                                markanev = f.Key,
                                atlag = Math.Round(f.Average(), 2),
                            };
            var eredmeny3 = from g in eredmeny2
                            orderby g.atlag descending
                            select g;
            dataGridView1.DataSource = eredmeny3.ToList();
                            

        }
    }
}
