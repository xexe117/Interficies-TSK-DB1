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

        public void lectura(List<ProductModel> products)
        {
            foreach (ProductModel product in products)
            {
                listBoxProducts.Items.Add(product.PNamDes);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.GetShowAll(lenguageComboBox.Text);

            lectura(products);
        }

        private void serchProductButt_Click(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();

            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.producName(lenguageComboBox.Text, enterProduct.Text, aviabelCheckBox.Checked);

            if (aviabelCheckBox.Checked == true)
            {
                lectura(products);
            } else if (aviabelCheckBox.Checked == false)
            {
                foreach (ProductModel product in products)
                {
                    listBoxProducts.Items.Add(product.PshowAll);
                }
            }
            
        }

        //private void aviabelCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
            //DataAcces db = new DataAcces();

            //List<ProductModel> products = new List<ProductModel>();

            //if (aviabelCheckBox.Checked == true)
            //{
            //    listBoxProducts.Items.Clear();

            //    products = db.producName(lenguageComboBox.Text, enterProduct.Text, aviabelCheckBox.Checked);

            //    lectura(products);
            //}
            //else if (aviabelCheckBox.Checked == false)
            //{
            //    listBoxProducts.Items.Clear();

            //    products = db.producName(lenguageComboBox.Text, enterProduct.Text, aviabelCheckBox.Checked);

            //    lectura(products);
            //}
        //}


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

        int currentpg = 0;

        private void numFilasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentpg = 0;

            int numtotalPg = calculpg();

            numPgLabel.Text = "Pag " + (currentpg + 1) + " of " + numtotalPg;

            DataAcces db = new DataAcces();
            List<ProductModel> products = new List<ProductModel>();

            listBoxProducts.Items.Clear();
            products = db.UpdateViewRowsPage(lenguageComboBox.Text, currentpg, numFilasComboBox.Text);

            lectura(products);
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            int numtotalPg = calculpg();


            DataAcces db = new DataAcces();
            List<ProductModel> products = new List<ProductModel>();

            if (currentpg >= numtotalPg)
            {
                currentpg = numtotalPg;
                numPgLabel.Text = "Pag " + (currentpg) + " of " + numtotalPg;
            }
            else
            {
                ++currentpg;

                numPgLabel.Text = "Pag " + (currentpg) + " of " + numtotalPg;
            }

            listBoxProducts.Items.Clear();

            products = db.UpdateViewRowsPage(lenguageComboBox.Text, currentpg - 1, numFilasComboBox.Text);

            lectura(products);
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            int numtotalPg = calculpg();
            --currentpg;

            DataAcces db = new DataAcces();
            List<ProductModel> products = new List<ProductModel>();

            if (currentpg <= 0)
            {
                listBoxProducts.Items.Clear();

                currentpg = 0;
                numPgLabel.Text = "Pag " + (currentpg) + " of " + numtotalPg;
            }
            else
            {
                --currentpg;
                numPgLabel.Text = "Pag " + (currentpg) + " of " + numtotalPg;

                listBoxProducts.Items.Clear();

                products = db.UpdateViewRowsPage(lenguageComboBox.Text, currentpg, numFilasComboBox.Text);

                lectura(products);
            }


        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();
            listBoxProducts.Items.Clear();

            products = db.Filtro(lenguageComboBox.Text, filterComboBox.Text);

            foreach (ProductModel product in products)
            {
                listBoxProducts.Items.Add(product.PNamFiltro);
            }
        }

        public int calculpg()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = "SELECT COUNT(*) " +
                                "FROM " +
                                    "Production.Product " +
                                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                $"WHERE ProductModelProductDescriptionCulture.CultureID = '{ lenguageComboBox.Text }' ";


                DataAcces db = new DataAcces();

                int totalNumeroDeProductes = connection.Query<int>(sql).FirstOrDefault();

                int numtotalPg = totalNumeroDeProductes / int.Parse(numFilasComboBox.Text) + 1;

                return numtotalPg;
            }
        }

        
    }
}
