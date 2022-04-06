using System;
using ClassLibrary1;
namespace Practise_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Store store = new Store();
            string check = "1";
            while (check != "0")
            {
                Console.WriteLine("Bir secim edin:");
                Console.WriteLine($"1-Product elave etmek\n2-Product Remove etmek\n" +
                    $"3-ProductFilterByType etmek\n4-ProductFilterByNmae\n0-Proqrami bitir");
                check = Console.ReadLine();
                if (check == "1")
                {
                    Console.WriteLine("Product sayi:");
                    int productCount = int.Parse(Console.ReadLine());
                    for (int i = 0; i < productCount; i++)
                    {
                        Console.WriteLine("Product Name-i:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Productun Type-in secin:");
                        foreach (var item in Enum.GetValues(typeof(ProductType)))
                        {
                            Console.WriteLine((int)item + "-" + item);
                        }
                        int type = 0;
                        bool check1 = false;
                        while(!check1)
                        {
                            try
                            {
                                type = int.Parse(Console.ReadLine());
                                check1 = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Yalniz integer deyer daxil edin!");
                                check1 = false;
                            }
                        }
                        while (!Enum.IsDefined(typeof(ProductType), type))
                        {
                            Console.WriteLine("dogru secim edin:");
                            type = int.Parse(Console.ReadLine());
                           

                        }
                         ProductType selectedType = (ProductType)type;
                        Console.WriteLine("Product Price-i:");
                        double price = double.Parse(Console.ReadLine());
                        Product product = new Product();
                        product.Name = name;
                        product.Price = price;
                        product.Type = selectedType;
                        store.AddProduct(product);
                    }
                }
                else if (check == "2")
                {
                    Console.WriteLine("Remove etmek istediyiniz Product-un no-su:");
                    int no = int.Parse(Console.ReadLine());
                    store.RemoveProductByNo(no);
                    foreach (Product product in store.Products)
                    {
                        Console.WriteLine($"Name:{product.Name} No:{product.No} Type:{product.Type} Price:{product.Price}");
                    }

                }
                else if (check == "3")
                {
                    Console.WriteLine("Filter etmek istediyiniz Product-un Type");
                    foreach (var item in Enum.GetValues(typeof(ProductType)))
                    {
                        Console.WriteLine((int)item + "-" + item);
                    }
                    int type = int.Parse(Console.ReadLine());
                    ProductType selectedType = (ProductType)type;
                    while (!Enum.IsDefined(typeof(ProductType), type))
                    {
                        Console.WriteLine("dogru secim edin:");
                        type = int.Parse(Console.ReadLine());
                        selectedType = (ProductType)type;
                    }
                    Product[] products = store.FilterProductsByType(selectedType);
                    foreach (Product product in products)
                    {
                        Console.WriteLine($"Name:{product.Name} No:{product.No} Type:{product.Type} Price:{product.Price}");
                    }
                }
                else if (check == "4")
                {
                    Console.WriteLine("Filter etmek istediyiniz Product-un Name-i");
                    string name = Console.ReadLine();
                    
                    foreach (Product product in store.FilterProductsByName(name))
                    {
                        Console.WriteLine($"Name:{product.Name} No:{product.No} Type:{product.Type} Price:{product.Price}");
                    }
                }
                else if(check == "0")
                    Console.WriteLine("Proqram bitti!");
                else
                    Console.WriteLine("secim sehvdi!");
            }
            
        }
    }
}
