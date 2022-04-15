namespace BlackFriday.ViewModel
{
    class ProductBlackFridayViewModel
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public int price { get; set; }
        public int bfPrice { get; set; }

        public ProductBlackFridayViewModel(string name, string manufacturer, int price, int bfprice)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.bfPrice = bfprice;
        }
    }
}
