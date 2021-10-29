using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
        // listimiz bes elemenden oluasti
            string[] list = new string[5];
            list[0] = "Merhaba";
            list[1] = "nailsin?";
            list[2] = "iyiyim";
            list[3] = "Sen ?";
            list[4] = "Tesekkurler.";
// for dongusu  integer olarak tanimladik k harfi verdik k = 0 sifir neden cunku 0'inci elmemenden baslasindi "indextir"
//k<5 cunku list 0'inci elemenden basladi icin dortte kadar gider 0-4 bes elemendir Kucuk olmak zorundadir 
// k++ yani her kere donguye bir artir i+1 soyledir 

            for (int k=0; k<5;k++)
            {
                Console.WriteLine(list[k] + "CSharp");
            }
// dongu bittikten sonra bitti diye ekrana yaz .
            Console.WriteLine("Bitti !.");

        }
    }
}
