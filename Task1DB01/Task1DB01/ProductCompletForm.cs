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

            products = db.GetShowAll(leng, words[4]);
            
            foreach (ProductModel product in products)
            {
                productCompletListBox.Items.Add(product.FullInfo);
            }
        }
    }
}
