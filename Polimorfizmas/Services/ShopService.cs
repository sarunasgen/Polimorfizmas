using Polimorfizmas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmas.Services
{
    public class ShopService
    {
        private List<Product> Products = new List<Product>();
        public void DisplayProducts()
        {
            foreach(Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
        public void DisplayProducts(List<Product> productsToDisplay)
        {
            foreach (Product p in productsToDisplay)
            {
                Console.WriteLine(p);
            }
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void AddProduct(string productName, decimal unitPrice, string productCode)
        {
            Products.Add(new Product { Name = productName, Code = productCode, UnitPrice = unitPrice });
        }
        public List<Product> GetAllHomeAppliances()
        {
            List<Product> foundProducts = new List<Product>();

            foreach(Product p in Products)
            {
                if (p is HomeAppliances)
                    foundProducts.Add(p);
            }
            return foundProducts;
        }

        public List<Product> GetAllFruits()
        {
            List<Product> foundProducts = new List<Product>();

            foreach (Product p in Products)
            {
                if (p is Fruit)
                    foundProducts.Add(p);
            }
            return foundProducts;
        }
    }
}
