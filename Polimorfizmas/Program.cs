using Polimorfizmas.Models;
using Polimorfizmas.Services;
using System;

namespace Polimorfizmas
{
    public class Program
    {
        public static void Main()
        {
            ShopService shopService = new ShopService();
            while(true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display All Products");
                Console.WriteLine("3. Find All Fruits");
                Console.WriteLine("4. Find All Home Appliances");
                string selectionInput = Console.ReadLine();
                switch(selectionInput)
                {
                    case "1":
                        Product productToAdd = null;
                        Console.WriteLine("Is new product a type of Home Appliance? yes/no");
                        if(Console.ReadLine() == "yes")
                        {
                            Console.WriteLine("Is electric true/false:");
                            bool isElectric = bool.Parse(Console.ReadLine());

                            Console.WriteLine("Product brand:");
                            string brand = Console.ReadLine();

                            Console.WriteLine("Product model:");
                            string model = Console.ReadLine();

                            productToAdd = new HomeAppliances { IsElectric = isElectric, Brand = brand, Model = model };
                        }
                        else
                        {
                            Console.WriteLine("Product weight in grams:");
                            int weightGrams = int.Parse(Console.ReadLine());
                            productToAdd = new Fruit { WeightInGrams = weightGrams };
                        }
                        Console.WriteLine("Product name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Product code:");
                        string code = Console.ReadLine();

                        Console.WriteLine("Product unit price:");
                        decimal price = decimal.Parse(Console.ReadLine());

                        productToAdd.Name = name;
                        productToAdd.UnitPrice = price;
                        productToAdd.Code = code;

                        shopService.AddProduct(productToAdd);
                        ////shopService.AddProduct(new Product { Code = code, Name = name, UnitPrice = price });

                        //shopService.AddProduct(name,price,code);
                        break;
                    case "2":
                        shopService.DisplayProducts();
                        break;
                    case "3":
                        shopService.DisplayProducts(shopService.GetAllFruits());
                        break;
                    case "4":
                        shopService.DisplayProducts(shopService.GetAllHomeAppliances());
                        break;
                }
            }
        }
    }
}