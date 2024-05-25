using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public interface IDrinkShop<T> where T : Product
    {
        void AddProduct(T product);
        void SellProduct(string name, int quantity);
        void DisplayProducts();
        void ShowIncome();
    }
}
