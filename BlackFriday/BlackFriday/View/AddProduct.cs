using BlackFriday.Controller;
using BlackFriday.DAO;
using BlackFriday.Model;
using System;
using System.Windows.Forms;

namespace BlackFriday
{
    public partial class AddProduct : Form
    {
        private readonly ProductController controller;

        public AddProduct()
        {
            InitializeComponent();
            controller = new ProductController(new ProductAdoDao());
            multiNum.Maximum = 99;
            multiNum.Minimum = 2;
            priceNum.Minimum = 1;
            priceNum.Maximum = 9999999999;
            bfpriceNum.Minimum = 2;
            bfpriceNum.Maximum = 9999999999;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            string name = nameText.Text;
            string manufacturer = manuText.Text;
            int price = (int)priceNum.Value;
            int multiplier = (int)multiNum.Value;
            int bfPrice = (int)bfpriceNum.Value;
            bool nameEq = false;
            foreach (var item in controller.GetProduct())
            {
                if (item.name == name)
                {
                    nameEq = true;
                }
            }

            if ((double)bfPrice > (double)multiplier / 100 * price + price)
            {
                DialogResult result = MessageBox.Show("Not good value for black friday price. Please, try it again.");
            }
            else if (name.Equals(""))
            {
                DialogResult result = MessageBox.Show("Name cannot be empty. Please, try it again.");
            }
            else if (manufacturer.Equals(""))
            {
                DialogResult result = MessageBox.Show("Manufacturer cannot be empty. Please, try it again.");
            }
            else if (nameEq)
            {
                DialogResult result = MessageBox.Show("This name is already exists. Please, try it again.");
            }
            else
            {
                Product product = new Product(name, manufacturer, price, multiplier, bfPrice);
                controller.AddProduct(product);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
