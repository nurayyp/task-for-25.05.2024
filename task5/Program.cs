using task5;

internal static class Program
{
    public static void Main()
    {
        Shop<Product> shop = new Shop<Product>();


        IDrinkShop<Product> shop2 = new Shop<Product>();

        while (true)
        {
            Console.WriteLine("Birini secin");
            Console.WriteLine("1- mehsul elave et");
            Console.WriteLine("2- mehsul sat");
            Console.WriteLine("3- mehsullari goster");
            Console.WriteLine("4- geliri goster");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProductToShop(shop);
                    break;
                case "2":
                    SellProductFromShop(shop);
                    break;
                case "3":
                    shop.DisplayProducts();
                    break;
                case "4":
                    shop.ShowIncome();
                    break;
                default:
                    Console.WriteLine("bele bir secim yoxdur");
                    break;
            }
        }
    }
    private static void AddProductToShop(Shop<Product> shop)
    {
        Console.WriteLine("mehsulu novunu secin: kofe ucun - c , cay ucun - t ");
        char productType = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("mehsulun adini daxil edin");
        string productName = Console.ReadLine();
        Console.WriteLine("mehsulun qiymetini daxil edin");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("mehsulun sayini daxil edin");
        int count = Convert.ToInt32(Console.ReadLine());
        if (productType == 't')
        {
            shop.AddProduct(new Tea(productName, count, price));
        }
        else if (productType == 'c')
        {
            shop.AddProduct(new Coffee(productName, count, price));
        }
        else
        {
            Console.WriteLine("bu mehsul novu movcud deyil");
        }
    }
    private static void SellProductFromShop(Shop<Product> shop)
    {
        Console.WriteLine("mehsulun adini daxil edin");
        string name = Console.ReadLine();
        Console.WriteLine("mehsulun sayini daxil edin");
        int quantity = Convert.ToInt32(Console.ReadLine());
        shop.SellProduct(name, quantity);
    }
}
