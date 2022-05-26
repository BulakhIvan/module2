using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xz;

namespace dz2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            while (true)
            {
                Console.WriteLine("print menu to open menu");
                Console.WriteLine("print exit to exit");
                string comand = Console.ReadLine();
                if (comand == "menu")
                {
                    Console.WriteLine("1)Warehouse");// 
                    Console.WriteLine("2)Cart");//
                    Console.WriteLine("3)ShowAllProducts");// 
                    Console.WriteLine("4)AddProductToCart");//
                    Console.WriteLine("5)IncreaseProductInCart");//
                    Console.WriteLine("6)DecreaseProductInCart");//
                    Console.WriteLine("7)RemoveProductFromCart");//
                    Console.WriteLine("8)Buy");//
                    string menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            Shop.WareHouse();
                            break;
                        case "2":
                            Shop.Cart();
                            break;
                        case "3":
                            Shop.ShowAllProducts();
                            break;
                        case "4":
                            Shop.AddProductToCart();
                            break;
                        case "5":
                            Shop.IncreaseProductInCart();
                            break;
                        case "6":
                            Shop.DecreaseProductInCart();
                            break;
                        case "7":
                            Shop.RemoveProductFromCart();
                            break;
                        case "8":
                            Shop.Buy();
                            break;
                    }
                }
                else if (comand == "exit")
                {
                    break;
                }
                 

            }
        }
    }
}
