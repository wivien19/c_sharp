namespace BlackFriday.Model
{
    class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public int price { get; set; }
        public int multiplier { get; set; }
        public int bfPrice { get; set; }
        public static bool goodvalue = true;
        public static bool goodPrice = true;

        public Product(int ID, string name, string manufacturer, int price, int multiplier, int bfPrice)
        {
            this.ID = ID;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.multiplier = multiplier;
            this.bfPrice = bfPrice;
        }


        public Product(string name, string manufacturer, int price, int multiplier, int bfPrice)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.multiplier = multiplier;
            this.bfPrice = bfPrice;
        }
    }
}
