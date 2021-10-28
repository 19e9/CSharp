using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] list = new string[5];
            //list[0] = "Merhaba";
            //list[1] = "nailsin?";
            //list[2] = "iyiyim";
            //list[3] = "Sen ?";
            //list[4] = "Tesekkurler.";
            //Console.WriteLine(list[0]+list[1]);


            int[] Numbers = new int[3];
            Numbers[0] = 6;
            Numbers[1] = 3;
            Numbers[2] = 1;
            Console.WriteLine("EnBuyuk Sayi :"+Numbers[0]);
            Console.WriteLine("Ortanci Sayi :" + Numbers[1]);
            Console.WriteLine("En Kucuk Sayi :" + Numbers[2]);


        }
    }
}
