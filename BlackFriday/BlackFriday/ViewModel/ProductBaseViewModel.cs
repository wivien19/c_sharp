namespace BlackFriday.ViewModel
{
    class ProductBaseViewModel
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public int price { get; set; }

        public ProductBaseViewModel(string name, string manufacturer, int price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
        }
    }
}
