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
    public partial class ProductCompletForm : Form
    {
        public ProductCompletForm()
        {
            InitializeComponent();
        }

        public ProductCompletForm(string leng, string name)
        {
            InitializeComponent();

            string[] words = name.Split('|');

            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.GetShowAll(leng, words[0]);
            
            //Aixo es un foreach, porque no se como fer que m'entri es contingut de products si no 
            foreach (ProductModel product in products)
            {
                productCompletListBox.Items.Add(product.FullInfo);
            }
        }

        private void updateButt_Click(object sender, EventArgs e)
        {
            // No se como aconseguir fer l'update serc pero no em queda clar i el que se m'ocorr me 
            // dona se sencacio de que es molt enfarragos com per que sigui valid
            string element = "";
            string name = updateElementcomboBox.Text;
            string[] word = productCompletListBox.Text.Split('|');
            int category = updateElementTextBox.SelectionLength;

            string contingut = word[category];

            switch (updateElementcomboBox.Text)
            {
                case "ProductCategory":
                    element = "ProductCategory";
                    name = "Name";
                    break;
                case "ProductSubcategory":
                    element = "ProductSubCategory";
                    name = "Name";
                    break;
                default:
                    element = "Product";
                    break;
            }
            DataAcces db = new DataAcces();

            List<ProductModel> products = new List<ProductModel>();

            products = db.updateProduct(element, name, name, contingut);

        }
    }
}
