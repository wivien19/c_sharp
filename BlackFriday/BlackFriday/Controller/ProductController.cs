using BlackFriday.DAO;
using BlackFriday.Model;
using System.Collections.Generic;
using System.Linq;

namespace BlackFriday.Controller
{
    class ProductController
    {
        private readonly IProduct dao;

        public ProductController(IProduct product)
        {
            dao = product;
        }
        public IEnumerable<Product> GetProduct()
        {

            return dao.GetProduct();
        }

        public bool AddProduct(Product product)
        {
            int id = dao.GetProduct().Count() + 1;
            product.ID = id;
            return dao.AddProduct(product);

        }
    }
}
