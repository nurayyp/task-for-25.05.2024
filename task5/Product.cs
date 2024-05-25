using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public Product(string name, int count, decimal price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
