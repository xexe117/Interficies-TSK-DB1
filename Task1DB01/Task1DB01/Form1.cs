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

        private void tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            //var output;            
        }

        public int idFullInfo = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                String output = "SELECT Production.ProductModel.Name AS ProductMOdel, " +
                    "Production.Product.Name, Production.Product.ProductNumber, Production.Product.MakeFlag, Production.Product.FinishedGoodsFlag,  Production.Product.Color, " +
                    "Production.Product.SafetyStockLevel, Production.Product.ReorderPoint, Production.Product.StandardCost, Production.Product.ListPrice, Production.Product.Size," +
                    "Production.Product.SizeUnitMeasureCode, Production.Product.WeightUnitMeasureCode, Production.Product.Weight, Production.Product.DaysToManufacture, " +
                    "Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.Product.ProductSubcategoryID, Production.Product.ProductModelID," +
                    "Production.Product.SellStartDate, Production.Product.SellEndDate, Production.Product.DiscontinuedDate, Production.Product.ModifiedDate " +
                "FROM " +
                    "Production.Product " +
                    "INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID " +
                    "INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID " +
                    "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                    "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                    "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                "WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL";

                List<ProductModel> products = new List<ProductModel>();
                products = connection.Query<ProductModel>(output).ToList();
                
                foreach(ProductModel product in products)
                {
                    tablas.Items.Add(product.FullInfo);
                }
            }
            
        }
    }
}
