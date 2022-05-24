using System;

namespace xz
{
    class Shop
    {
        public string WareHouse (string a)
        {
            string[] warehouse = new string[10];
            int[] masivA = new int[10];
            for (int i = 0; i < masivA.Length; i++)
            {
                Random randNum = new Random();
                masivA[i] = randNum.Next(1, 10);
            }
            for (int i = 0; i < warehouse.Length; i++)
            {

                Console.WriteLine(i++ + " " + warehouse[i] + );
            }
        }

    }
}
