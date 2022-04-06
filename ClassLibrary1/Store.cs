using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Store
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public void RemoveProductByNo(int no)
        {
            Product[] products = new Product[0];
            foreach (var pr in Products)
            {
                if (pr.No != no)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = pr;
                }
            }
            Products = products;
            
        }
        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] products = new Product[0];
            foreach (var pr in Products)
            {
                if(pr.Type == type)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length-1] = pr;
                }
            }
            return products;
        }
        public Product[] FilterProductsByName(string name)
        {
            Product[] products = new Product[0];
            foreach (var pr in Products)
            {
                if (pr.Name == name)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = pr;
                }
            }
            return products;
        }



    }
}

