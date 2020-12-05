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

            //int totalPG = db.numerototalPG(lenguageComboBox.Text, currentpg, cantidad);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                int currentpg = 0;
                string sql = "SELECT COUNT(*), Production.ProductModel.Name AS ProductMOdel, Production.ProductDescription.Description " +
                                "FROM " +
                                    "Production.Product " +
                                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                $"WHERE ProductModelProductDescriptionCulture.CultureID = '{ lenguageComboBox }' " +
                                $"ORDER BY Production.ProductModel.Name OFFSET { currentpg } ROWS FETCH NEXT { numFilasComboBox.Text } ROWS ONLY";


                DataAcces db = new DataAcces();

                int totalNumeroDeProductes = connection.Query<int>(sql).FirstOrDefault();


                numPgLabel.Text = "Pag " + (currentpg + 1) + " of " + totalNumeroDeProductes / int.Parse(numFilasComboBox.Text) + 1;
                List<ProductModel> products = new List<ProductModel>();

                listBoxProducts.Items.Clear();

                products = connection.Query<ProductModel>(sql).ToList();

                foreach (ProductModel product in products)
                {
                    listBoxProducts.Items.Add(product.NamDes);
                }
            }        
        }
    }
}
