using BlackFriday.Controller;
using BlackFriday.DAO;
using BlackFriday.Model;
using BlackFriday.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackFriday
{
    public partial class ListProducts : Form
    {
        private readonly ProductController controller;
        IEnumerable<Product> items;

        List<ProductBaseViewModel> viewModels = new List<ProductBaseViewModel>();
        public ListProducts()
        {
            InitializeComponent();
            controller = new ProductController(new ProductAdoDao());
            items = controller.GetProduct();

            viewModels = new List<ProductBaseViewModel>();


            foreach (var item in items)
            {
                string name = item.name;
                string manufacturer = item.manufacturer;
                int price = item.price;

                viewModels.Add(new ProductBaseViewModel(name, manufacturer, price));
            }
            listProdGrid.DataSource = null;
            listProdGrid.DataSource = viewModels;
            listProdGrid.Columns[0].HeaderText = "Name";
            listProdGrid.Columns[1].HeaderText = "Manufacturer";
            listProdGrid.Columns[2].HeaderText = "Price";
            listProdGrid.Visible = true;
            this.listProdGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void blackFridayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blackFridayCheckBox.Checked)
            {
                var items = controller.GetProduct();
                var viewModels = new List<ProductBlackFridayViewModel>();
                foreach (var item in items)
                {

                    string name = item.name;
                    string manufacturer = item.manufacturer;
                    int price = (int)(item.price + (item.price * ((double)item.multiplier / 100)));
                    int bfPrice = item.bfPrice;

                    viewModels.Add(new ProductBlackFridayViewModel(name, manufacturer, price, bfPrice));
                }
                listProdGrid.DataSource = null;
                listProdGrid.DataSource = viewModels;
                listProdGrid.Columns[0].HeaderText = "Name";
                listProdGrid.Columns[1].HeaderText = "Manufacturer";
                listProdGrid.Columns[2].HeaderText = "Original Price";
                listProdGrid.Columns[3].HeaderText = "Special Price";
                listProdGrid.Visible = true;
            }
            else
            {
                viewModels = new List<ProductBaseViewModel>();
                foreach (var item in items)
                {

                    string name = item.name;
                    string manufacturer = item.manufacturer;
                    int price = item.price;


                    viewModels.Add(new ProductBaseViewModel(name, manufacturer, price));
                }
                listProdGrid.DataSource = null;
                listProdGrid.DataSource = viewModels;
                listProdGrid.Columns[0].HeaderText = "Name";
                listProdGrid.Columns[1].HeaderText = "Manufacturer";
                listProdGrid.Columns[2].HeaderText = "Price";
                listProdGrid.Visible = true;
            }
        }

        private void okListButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
