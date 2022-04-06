using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Product
    {
        static int _noCount = 0;
        public Product()
        {
            _noCount++;
            No = _noCount; 
        }
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
    }
}
