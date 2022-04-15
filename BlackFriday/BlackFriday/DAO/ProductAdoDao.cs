using BlackFriday.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BlackFriday.DAO
{
    class ProductAdoDao : IProduct
    {
        string connectPath = @"Data Source= ../../../../DB/blackFriday.db;";

        public bool AddProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }
            if (product.name.Equals("") || product.manufacturer.Equals(""))
            {
                return false;
            }
            using SQLiteConnection con = new SQLiteConnection(connectPath);
            con.Open();
            SQLiteCommand command = con.CreateCommand();
            command.CommandText = "insert into Products "
                + "(Name, Manufacturer, Price, Multiplier, BFPrice) values "
                + "(@name, @manufacturer, @price, @multiplier, @bfPrice );";
            command.Parameters.Add("name", System.Data.DbType.String).Value = product.name;
            command.Parameters.Add("manufacturer", System.Data.DbType.String).Value = product.manufacturer;
            command.Parameters.Add("price", System.Data.DbType.Int32).Value = product.price;
            command.Parameters.Add("multiplier", System.Data.DbType.Int32).Value = product.multiplier;
            command.Parameters.Add("bfPrice", System.Data.DbType.Int32).Value = product.bfPrice;
            command.ExecuteNonQuery();


            bool ret = true;
            con.Close();
            return ret;
        }

        public IEnumerable<Product> GetProduct()
        {
            List<Product> allProducts = new List<Product>();

            using SQLiteConnection con = new SQLiteConnection(connectPath);
            con.Open();

            SQLiteCommand command = con.CreateCommand();
            command.CommandText = "select * from Products";
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ID = (int)reader.GetInt32(reader.GetOrdinal("ID"));
                string name = reader.GetString(reader.GetOrdinal("Name"));
                string manufacturer = reader.GetString(reader.GetOrdinal("Manufacturer"));
                int price = (int)reader.GetInt32(reader.GetOrdinal("Price"));
                int multiplier = (int)reader.GetInt32(reader.GetOrdinal("Multiplier"));
                int bfPrice = (int)reader.GetInt32(reader.GetOrdinal("BFPrice"));

                allProducts.Add(new Product(ID, name, manufacturer, price, multiplier, bfPrice));
            }
            con.Close();
            return allProducts;
        }
    }
}
