using System;

namespace Csharpintro
{
    class Program
    {
        static void Main(string[] args)
        {

            double Satis = 150.6;
            double Alis = 144.5;

            //Eger Satis yeksek'se sarti okuyup true olarak hemen artis mesajini gostrer. 
            //Eger alis kucuk'se sart false okuyup hmen azalis mesajini gostrer.
           
            bool sonuc = Satis > Alis;

            string MesajArtis = "Artis oku.";
            string MesajAzalis = "Azalis oku.";
            if (sonuc == true)
            {
                Console.WriteLine(MesajArtis);
            }
            else
            {
                Console.WriteLine(MesajAzalis);
            }


        }
    }
}
