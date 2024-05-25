using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Shop<T> : IDrinkShop<T> where T : Product
    {
        public Shop()
        {
            TotalIncome = 0;
            products = new Product[4];
            capacity = products.Length;
        }
        private Product[] products;
        public double TotalPrice { get; private set; }
        public double TotalIncome { get; private set; }
        private int capacity;
        private int count;
        public void AddProduct(T product)
        {
            if (products is not null)
            {
                if (ProductExists(product.Name))
                {
                    Console.WriteLine("mehsul movcuddur");
                    return;
                }
            }
            if (count == capacity)
            {
                Array.Resize(ref products, capacity == 0 ? 4 : products.Length * 2);
                capacity = products.Length;
            }
            products[count] = product;
            count++;
        }
        public void SellProduct(string name, int quantity)
        {
            if (!ProductExists(name))
            {
                Console.WriteLine("bu mehsul yoxdur");
                return;
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    if (products[i].Count >= quantity)
                    {
                        products[i].Count -= quantity;
                        TotalIncome += (double)(quantity * products[i].Price);

                        if (products[i].Count == 0)
                        {
                            products[i] = products[count - 1];
                            products[count - 1] = null;
                            count--;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("bu qeder mehsul yoxdur");
                        return;
                    }
                }
            }
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Mehsullar - ");
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    break;
                }
                Console.WriteLine($"Name :{products[i].Name} Price: {products[i].Price} Count: {products[i].Count} Type: {products[i].ToString()} ");
            }
        }
        public void ShowIncome()
        {
            Console.WriteLine($"umumi gelir - {TotalIncome}");
        }
        private bool ProductExists(string productName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is not null)
                {
                    if (products[i].Name == productName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
