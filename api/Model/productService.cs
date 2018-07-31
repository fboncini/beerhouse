using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace New_folder.Model
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            var pepe = File.ReadAllText("Model/productos.json");
            var products = JsonConvert.DeserializeObject<ProductList>(pepe);
            return products.Products;
        }

        public Product GetById(int id)
        {
            var producList = GetAll();
            var product = producList.Find(s => s.Id.Equals(id));
            return product;
        }

        public List<Product> GetByCategory(string category)
        {
            var producList = GetAll();
            var product = producList.FindAll(s => s.Category.Equals(category));
            return product;
        }
    }
}