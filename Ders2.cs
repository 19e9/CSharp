using System;

namespace Csharpintro
{
    class Program
    {
        static void Main(string[] args)
        {

            double Satis = 150.6;
            double Alis = 150.6;

            //Eger Satis Ve Alis ayni Fiyat'sa sabit fiyati okuar
            
           
            bool sonuc = Satis == Alis;

            string MesajArtis = "Artis oku.";
            string MesajAzalis = "Azalis oku.";
            string MesajAyni = "Sabit oku";
            if (Satis > Alis)
            {
                Console.WriteLine(MesajArtis);
            }
            else if (Satis == Alis)
            {
                Console.WriteLine(MesajAyni);
            }
            else
            {
                Console.WriteLine(MesajAzalis);
            }


        }
    }
}
