using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Car : Icar
    {
        public int Consumption { get; set; }
        public int Volume { get; set; }
        public int Power { get; set; }
        public int TopSpeed { get; set; }
        public void  DVS()
        {
            Console.WriteLine("say adress and we go");// for redact
        }
    }
    class RX7 : Car
    {
        public int[] DVSR()
        {
            Consumption = 13;
            Volume = 1;
            Power = 398;
            TopSpeed = 320;
            int[] dvsR = { Consumption, Volume, Power, TopSpeed };
            return dvsR;
        }
        public string[] CarBodyR()
        {
            var a = new Field();
            string marka = a.Name[4];
            string type = a.CarBody[0];
            string comfort = a.CarClass[2];
            string pass = a.Passenger[0];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyR = { marka, type, comfort, pass, color };
            return carBodyR;
        }
    }
    class Camry : M5
    {
        public int[] DVSCT()
        {
            Consumption = 8;
            Volume = 4;
            Power = 268;
            TopSpeed = 260;
            int[] dvsCT = { Consumption, Volume, Power, TopSpeed };
            return dvsCT;
        }
        public string[] CarBodyCT()
        {
            var a = new Field();
            string marka = a.Name[1];
            string type = a.CarBody[1];
            string comfort = a.CarClass[1];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyCT = { marka, type, comfort, pass, color };
            return carBodyCT;
        }
    }
    class M5:Car
    {
        public int[] DVSM()
        {
            Consumption = 9;
            Volume = 4;
            Power = 358;
            TopSpeed = 290;
            int[] dvsM = { Consumption, Volume, Power, TopSpeed };
            return dvsM;
        }
        public string[] CarBodyM()
        {
            var a = new Field();
            string marka = a.Name[0];
            string type = a.CarBody[1];
            string comfort = a.CarClass[1];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyM = { marka, type, comfort, pass, color };
            return carBodyM;
        }
    }
    class EClass : M5
    {
        public int[] DVSE()
        {
            Consumption = 10;
            Volume = 3;
            Power = 278;
            TopSpeed = 320;
            int[] dvsE = { Consumption, Volume, Power, TopSpeed };
            return dvsE;
        }
        public string[] CarBodyE()
        {
            var a = new Field();
            string marka = a.Name[6];
            string type = a.CarBody[1];
            string comfort = a.CarClass[1];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyE = { marka, type, comfort, pass, color };
            return carBodyE;
        }
    }
    class Civic: Car
    {
        public int[] DVSC()
        {
            Consumption = 6;
            Volume = 2;
            Power = 198;
            TopSpeed = 240;
            int[] dvsC = {Consumption,Volume,Power,TopSpeed};
            return dvsC;
        }
        public string[] CarBodyC()
        {
            var a = new Field();
            string marka = a.Name[5];
            string type = a.CarBody[2];
            string comfort = a.CarClass[0];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyC = { marka, type, comfort, pass, color };
            return carBodyC;
        } 
    }
    class Golf: Civic
    {
        public int[] DVSG()
        {
            Consumption = 5;
            Volume = 2;
            Power = 188;
            TopSpeed = 240;
            int[] dvsG = { Consumption, Volume, Power, TopSpeed };
            return dvsG;
        }
        public string[] CarBodyG()
        {
            var a = new Field();
            string marka = a.Name[3];
            string type = a.CarBody[2];
            string comfort = a.CarClass[0];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyG = {marka, type, comfort, pass,color};
            return carBodyG;
        }
    }
    class Picanto : Golf
    {
        public int[] DVSP()
        {
            Consumption = 4;
            Volume = 2;
            Power = 108;
            TopSpeed = 200;
            int[] dvsP = { Consumption, Volume, Power, TopSpeed };
            return dvsP;
        }
        public string[] CarBodyP()
        {
            var a = new Field();
            string marka = a.Name[2];
            string type = a.CarBody[2];
            string comfort = a.CarClass[0];
            string pass = a.Passenger[1];
            Random random = new Random();
            string color = a.Color[random.Next(0, 5)];
            string[] carBodyP = { marka, type, comfort, pass, color };
            return carBodyP;
        }
    }
    class Field
    {
        string[] name = { "BMW","TOYOTA","KIA", "VW","Mazda","Honda","Mersedes" };
        string[] carBody = { "coupe", "sedan", "hatchback" };
        string[] color = {"green","blue","red","white","black","yellow"};
        string[] carClass = { "econom", "comfort", "sport"};
        string[] passenger = { "1", "3" };
        public string[] Name { get { return name; } }
        public string[] CarBody { get { return carBody; } }
        public string[] Color { get { return color; } }
        public string[] CarClass { get { return carClass; } }
        public string[] Passenger { get { return passenger; } }
    }
}
 