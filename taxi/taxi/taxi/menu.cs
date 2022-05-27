using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI. What car do you need?");
            Console.WriteLine("we have 1)honda civic, 2)kia picanto, 3)bmw m5, 4)mersedes e class, 5)vw Golf, 6)mazda rx7, 7)toyota camry");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with honda civic");
                    break;
                case 2:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with kia picanto");
                    break;
                case 3:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with bmw m5");
                    break;
                case 4:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with mersedes e class");
                    break;
                case 5:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with vw Golf");
                    break;
                case 6:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with mazda rx7");
                    break;
                case 7:
                    Console.WriteLine("great choice");
                    Console.WriteLine("enjoy your trip with toyota camry");
                    break;
            }
            while (true)
            {
                Console.WriteLine("press 1 to view characteristics");
                string comand = Console.ReadLine();
                if (comand == "1")
                {
                    Console.WriteLine("what do you want see characteristics or sort?");
                    Console.WriteLine("1 for characteristics and 2 for sort");
                    string menu =Console.ReadLine();
                    switch (menu)
                    {
                        case "1":
                            string cars = Console.ReadLine();
                            switch (cars)
                            {
                                case "1":
                                    Console.WriteLine("civic");
                                    
                                    break;
                                case "2":
                                    break;
                            }
                            break;
                        case "2":
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
