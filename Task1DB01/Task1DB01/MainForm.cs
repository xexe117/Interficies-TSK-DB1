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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Lectura(List<ProductModel> products)
        {
            foreach (ProductModel product in products)
            {
                listBoxProducts.Items.Add(product.PNamDes);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.GetShow(lenguageComboBox.Text);

            Lectura(products);
        }

        private void serchProductButt_Click(object sender, EventArgs e)
        {
            listBoxProducts.Items.Clear();

            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.producName(lenguageComboBox.Text, enterProduct.Text, aviabelCheckBox.Checked);

            if (aviabelCheckBox.Checked == true)
            {
                Lectura(products);
            } else if (aviabelCheckBox.Checked == false)
            {
                foreach (ProductModel product in products)
                {
                    listBoxProducts.Items.Add(product.PshowAll);
                }
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

                Lectura(products);
            }
            else if (aviabelCheckBox.Checked == false)
            {
                listBoxProducts.Items.Clear();

                products = db.GetShow(lenguageComboBox.Text);

                Lectura(products);
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

            Lectura(products);
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

            Lectura(products);
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

                Lectura(products);
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

        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            ProductCompletForm pc = new ProductCompletForm(lenguageComboBox.Text, listBoxProducts.Text);
            pc.ShowDialog();
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
