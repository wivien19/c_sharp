using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackFridayWeb.Models
{
    [Index(nameof(name), IsUnique = true)]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        
        public string name { get; set; }

        [Required]
        public string manufacturer { get; set; }

        [Required]
        public int price { get; set; }

        [Required]
        public int multiplier { get; set; }

        [Required]
        public int bfPrice { get; set; }

        [Required]
        public static bool goodvalue = true;

        [Required]
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
        public Product()
        {
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
