using StoreClasses;
using StoreClasses.Exceptions;
using StoreClasses.Implementation;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BravoMarket market = new BravoMarket(20);

            string opt;
            do
            {
                Console.WriteLine("1. Product elave et");
                Console.WriteLine("2. Product sat");
                Console.WriteLine("3. Productlara bax");
                Console.WriteLine("4. Cix");

                Console.WriteLine("\n Emeliyyati secin:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        AddProduct(market);
                        break;
                    case "2":
                        SellProduct(market);
                        break;
                    case "3":
                        ShowProduct(market);
                        break;
                    case "4":
                        Console.WriteLine("Sitemden cixacaq");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdini!");
                        break;
                }


            } while (opt!="4");
        }

        static Product GetProductFromConsole()
        {
            Console.WriteLine("Mehsulun nomresini daxil edin:");
            string no = Console.ReadLine();

            Console.WriteLine("Mehsulun adini daxil edin:");
            string name = Console.ReadLine();


            string countStr;
            int count;
            do
            {
                Console.WriteLine("Mehsulun sayini daxil edin:");
                countStr = Console.ReadLine();

            } while (!int.TryParse(countStr,out count) || count<0);


            string priceStr;
            double price;

            do
            {
                Console.WriteLine("Mehsulun qiymetini daxil edin:");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr,out price) || price<0);

            Product product = new Product
            {
                No = no,
                Name = name,
                Count = count,
                Price = price
            };

            return product;
        }

        static string GetProductNoFromConsole()
        {
            Console.WriteLine("Satmaq istediyiniz mehsul nomresini daxil edin");
            string no = Console.ReadLine();

            return no;
        }

        static void AddProduct(BravoMarket market)
        {
            try
            {
                Product product = GetProductFromConsole();
                market.AddProduct(product);
            }
            catch (ProductLimitIsFilledException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (ProductIsExistException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmedik bir xeta bas verdi");
            }
        }

        static void SellProduct(BravoMarket market)
        {
            string no = GetProductNoFromConsole();
            try
            {
                market.SellProduct(no);
            }
            catch (ProductNotFoundException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (ProductStockCountException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bilinmedik bir xeta bas verdi");
            }
        }

        static void ShowProduct(BravoMarket market)
        {
            foreach (var pr in market.Products)
            {
                pr.ShowInfo();
            }
        }
    }
}
