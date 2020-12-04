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

 

        public int idFullInfo = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.GetShowAll();

            foreach (ProductModel product in products)
            {
                listBoxProducts.Items.Add(product.FullInfo);
            }
        }

        private void aviabelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            if (aviabelCheckBox.Checked = true){
                listBoxProducts.Items.Clear();

                products = db.GetAviabel();

                foreach (ProductModel product in products)
                {
                    listBoxProducts.Items.Add(product.FullInfo);
                }
            } else if (aviabelCheckBox.Checked = false)
            {
                listBoxProducts.Items.Clear();

                products = db.GetShowAll();

                foreach (ProductModel product in products)
                {
                    listBoxProducts.Items.Add(product.FullInfo);
                }
            } 
        }
    }
}
