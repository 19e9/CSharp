using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];
            list[0] = "Merhaba";
            list[1] = "nailsin?";
            list[2] = "iyiyim";
            list[3] = "Sen ?";
            list[4] = "Tesekkurler.";

            for (int k=0; k<5; k++)
            {
                Console.WriteLine(list[k] + "CSharp");
            }

            Console.WriteLine("For dongusu bitti !!. ");

            foreach (var oku in list)
            {
                Console.WriteLine(oku);
            }

            Console.WriteLine("Bitti !.");

            // while for isini yapar yani ayni isi yapar
            int sayac = 0;
            while (true)
            {
                Console.WriteLine(list[sayac]);
                sayac++;
            }
        }
    }
}
