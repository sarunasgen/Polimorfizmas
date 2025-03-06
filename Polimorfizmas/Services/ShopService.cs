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
            SaveProductsToFile();
        }
        public void AddProduct(string productName, decimal unitPrice, string productCode)
        {
            Products.Add(new Product { Name = productName, Code = productCode, UnitPrice = unitPrice });
            SaveProductsToFile();
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
        public void ReadAllProducts()
        {
            Products.Clear();
            Products.AddRange(ReadAllFruits("Fruits.csv"));
            Products.AddRange(ReadAllHomeAppliances("HomeAppliances.csv"));
        }
        public List<Fruit> ReadAllFruits(string filePath)
        {
            List<Fruit> fruits = new List<Fruit>(); 
            StreamReader sr = new StreamReader(filePath);
            while(!sr.EndOfStream)
            {
                fruits.Add(new Fruit(sr.ReadLine()));
            }
            sr.Close();

            return fruits;
        }
        public List<HomeAppliances> ReadAllHomeAppliances(string filePath)
        {
            List<HomeAppliances> ha = new List<HomeAppliances>();
            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                ha.Add(new HomeAppliances(sr.ReadLine()));
            }
            sr.Close();

            return ha;
        }
        public void SaveProductsToFile()
        {
            List<Product> fruits = new List<Product>();
            List<Product> ha = new List<Product>();
            foreach(Product product in Products)
            {
                if(product is Fruit)
                {
                    fruits.Add((Fruit)product);
                }
                else
                {
                    ha.Add((HomeAppliances)product);
                }
            }
            //SaveFruits(fruits);
            //SaveHomeAppliances(ha);
            SaveProductsOfOneKindToFile(fruits, "Fruits.csv");
            SaveProductsOfOneKindToFile(ha, "HomeAppliances.csv");
        }
        private void SaveProductsOfOneKindToFile(List<Product> productsToSave, string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            foreach (Product item in productsToSave)
            {
                sw.WriteLine(item.ToCsvString());
            }
            sw.Close();
        }
        //private void SaveFruits(List<Fruit> fruits, string filePath = "Fruits.csv")
        //{
        //    StreamWriter sw = new StreamWriter(filePath);
        //    foreach(Fruit item in fruits)
        //    {
        //        sw.WriteLine(item.ToCsvString());
        //    }
        //    sw.Close();
        //}
        //private void SaveHomeAppliances(List<HomeAppliances> appliances, string filePath = "HomeAppliances.csv")
        //{
        //    StreamWriter sw = new StreamWriter(filePath);
        //    foreach (HomeAppliances item in appliances)
        //    {
        //        sw.WriteLine(item.ToCsvString());
        //    }
        //    sw.Close();
        //}
    }
}
