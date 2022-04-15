using System;
using System.Windows.Forms;

namespace BlackFriday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listProduct_Click(object sender, EventArgs e)
        {
            using var listAllProducts = new ListProducts();

            listAllProducts.ShowDialog();
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            using var addNewProduct = new AddProduct();
            addNewProduct.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
