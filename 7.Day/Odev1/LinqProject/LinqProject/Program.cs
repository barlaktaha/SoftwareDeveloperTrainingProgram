using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitInStock=5 },
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=8000,UnitInStock=3 },
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=6000,UnitInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitInStock=15 },
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=8000,UnitInStock=0 },
            };

            Console.WriteLine("Algoritmik ile yazınca ------------------------\n ");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitInStock > 3)
                {
                    Console.WriteLine(item.ProductName + "\n");
                };
            }
            Console.WriteLine("LinQ ile yazınca ------------------------------\n ");
          
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName + "\n");
            }

            GetProducts(products);

            static List<Product> GetProducts(List<Product> products)
            {
                List<Product> filteredProducts = new List<Product>();
                
                    foreach (var product in products)
                    {
                            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                            {
                                 filteredProducts.Add(product);
                            }
                    }
                    return filteredProducts;
            
            }


            GetProductsLinq(products);

            static List<Product> GetProductsLinq(List<Product> products) 
            {
                return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
            }
            
        }
    }
}


