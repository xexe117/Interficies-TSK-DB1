using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1DB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterProduct_TextChanged(object sender, EventArgs e)
        {

        }

        public void lectura(List<ProductModel> products)
        {
            foreach (ProductModel product in products)
            {
                listBoxProducts.Items.Add(product.FullInfo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.GetShowAll(lenguageComboBox.Text);

            lectura(products);
        }

        private void aviabelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            if (aviabelCheckBox.Checked == true)
            {
                listBoxProducts.Items.Clear();

                products = db.GetAviabel(lenguageComboBox.Text);

                lectura(products);
            }
            else if (aviabelCheckBox.Checked == false)
            {
                listBoxProducts.Items.Clear();

                products = db.GetShowAll(lenguageComboBox.Text);

                lectura(products);
            } 
        }


        private void lenguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            if (aviabelCheckBox.Checked == true)
            {
                listBoxProducts.Items.Clear();

                products = db.GetAviabel(lenguageComboBox.Text);

                lectura(products);

            }
            else if (aviabelCheckBox.Checked == false)
            {
                listBoxProducts.Items.Clear();

                products = db.GetShowAll(lenguageComboBox.Text);

                lectura(products);
            }
        }

        private void numFilasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentpg = 0;
            int cantidad = 10;

            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            listBoxProducts.Items.Clear();

            products = db.UpdateViewRowsPage(lenguageComboBox.Text, currentpg, cantidad);

            lectura(products);
        }
    }
}
