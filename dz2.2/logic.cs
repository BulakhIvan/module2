using System;
using xz;
namespace xz
{
    public class Shop
    {

        public Shop()
        {
                 
        }
        private string[] cart = new string[10];
        private int[] productQuantity = new int[10]; //количестово продуктов in warehouse
        //private string[] warehouse = new string[10];
        private string[] warehouse = { "apple", "orange", "cucumber", "honeydew", "grapes", "grapefruit", "garlic", "Pears", "Potatoes", "Cherries" };
        private int[] quantityProductInCart = new int[10]; //количестово продуктов в корзине
        //get set
       public int[] ProductQuantity
        {
            get { return productQuantity; }
            set
            {
                productQuantity = value;
            }
        }
        public int[] QuantityProductInCart { get; set; }
        string[] _Cart { get; set; }
        private void ware()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                ProductQuantity[i] = rand.Next(1,10);
            }
        }

        public string[] Warehouse
        {
            get { return warehouse; }
            //set { warehouse = { "apple", "orange", "cucumber", "honeydew", "grapes", "grapefruit", "garlic", "Pears", "Potatoes", "Cherries" } }
        }

        //logic
        static public void WareHouse(ref int[] ProductQuantity, ref string[] Warehouse)
        {
            int a = 1;
            for (int i = 0; i < 10; i++)// выводд всех продуктот и их количество
            {
                a=a + i;
                Console.WriteLine(a + ")"+ Warehouse[i] + ProductQuantity[i]); 
            }
            
        }
        static public  void ShowAllProducts(ref string[] Warehouse)//все продукти
        {
            int a = 1;
            for (int i = 0; i < 10; i++)// выводд всех продуктот
            {
                a = a + i;
                Console.WriteLine(a + ")" + Warehouse[i]);
            }

        }
        static public void Cart(ref string[] _Cart, ref int[] QuantityProductInCart)// вся корзина 
        {
            if (_Cart[0] == null)
            {
                int a = 1;
                for (int i = 0; i < 10; i++)// выводд всех продуктот
                {
                    a = a + i;
                    Console.WriteLine(a + ")" + _Cart[i] + QuantityProductInCart[i]);
                }
            }
            else
            {
                Console.WriteLine("your cart is empety");
            }
        }
        static public void AddProductToCart(ref string[] _Cart, ref int[] QuantityProductInCart, ref string[] Warehouse)
        {
            Console.WriteLine("what product do you add? ");
            int productNumb= Convert.ToInt32(Console.ReadLine())-1;
            if (productNumb < 10 && productNumb >= 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (_Cart[i] == null)
                    {
                        _Cart[i] = Warehouse[productNumb];
                        QuantityProductInCart[i] = QuantityProductInCart[i] + 1;
                    }
                }
            }
            else
                Console.WriteLine("invalide numb");
        }
        static public void IncreaseProductInCart(ref int[] ProductQuantity, ref int[] QuantityProductInCart)
        {
            Console.WriteLine("what product do you want increase by 1? ");
            Console.WriteLine("press numb of product");
            int productNumb=Convert.ToInt32( Console.ReadLine())-1;
            if (productNumb < 10 && productNumb >= 0)
            {
                QuantityProductInCart[productNumb] = QuantityProductInCart[productNumb] + 1;
                if (QuantityProductInCart[productNumb] > ProductQuantity[productNumb])
                {
                    Console.WriteLine("you want too much))");
                    QuantityProductInCart[productNumb] = ProductQuantity[productNumb];
                }

            }
            else 
                Console.WriteLine("invalide numb");
        }
        static public void DecreaseProductInCart(ref string[] _Cart, ref int[] QuantityProductInCart)
        {
            Console.WriteLine("what product do you want decrease by 1? ");
            Console.WriteLine("press numb of product");
            int productNumb = Convert.ToInt32(Console.ReadLine()) - 1;
            if (productNumb < 10 && productNumb >= 0)
            {
                QuantityProductInCart[productNumb] = QuantityProductInCart[productNumb] - 1;
                if (QuantityProductInCart[productNumb] == 0)
                {
                    Remove(ref _Cart, ref QuantityProductInCart, productNumb);
                }
            }
            else
                Console.WriteLine("invalide numb");
        }
        static public void RemoveProductFromCart(ref string[] _Cart, ref int[] QuantityProductInCart)
        {
            Console.WriteLine("what product do you want remove? ");
            Console.WriteLine("press numb of product");
            int productNumb = Convert.ToInt32(Console.ReadLine()) - 1;
            if (productNumb < 10 && productNumb >=0)
            {
                Remove(ref _Cart, ref QuantityProductInCart, productNumb);
            }
            else
                Console.WriteLine("invalide numb");
        }
        public static void Buy(ref string[] _Cart, ref int[] QuantityProductInCart)// вывод корзины
        {
            int a = 1;
            for (int i=0; i<10 ; i++) 
            { 
                 Console.WriteLine("you buy :");
                a = a + i;
                Console.WriteLine(a + ")" + _Cart[i] + QuantityProductInCart[i]);
                Console.WriteLine("Thank you for your purchase");

            }
        }
         private static void Remove (ref string[] _Cart, ref int[] QuantityProductInCart,int index)
         {
            string[] new_Cart=new string[_Cart.Length-1];
            for (int i=0; i<index; i++)
            {
                new_Cart[i]= _Cart[i];
            }
            for(int i=index+1; i<_Cart.Length; i++)
            {
                new_Cart[i-1] = _Cart[i];
            }
            _Cart=new_Cart;
            int[] newQuantityProductInCart = new int[QuantityProductInCart.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newQuantityProductInCart[i] = QuantityProductInCart[i];
            }
            for (int i = index + 1; i < QuantityProductInCart.Length; i++)
            {
                newQuantityProductInCart[i - 1] = QuantityProductInCart[i];
            }
            QuantityProductInCart = newQuantityProductInCart;
         }
    }
}
