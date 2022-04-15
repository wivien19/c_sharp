using BlackFriday.Model;
using System.Collections.Generic;

namespace BlackFriday.DAO
{
    interface IProduct
    {
        bool AddProduct(Product product);

        IEnumerable<Product> GetProduct();
    }
}
