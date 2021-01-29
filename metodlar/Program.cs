using System;

namespace metotlar
{
    class Urun
    {
        private string adi, fiyati ,aciklama;

        static void Main(string[] args)

        

        

        {

            string urunadi  = "elma";
            double fiyati   = 23;
            string aciklama = "amasya elma";


            string[] meyveler = new string[] { "elma", "armut" };

            

            Urun urun11 = new Urun();
            urun11.adi = "elma";
            urun11.aciklama = "amasya elma";
            
           
            
            Urun urun12 = new Urun();
            urun12.adi = "armut";
            urun12.aciklama = "amasya armut";

            Urun[] urunler = new Urun[] { urun11, urun12 };


            foreach (var urun in urunler) 

            {

                Console.WriteLine(urun11.adi);
                Console.WriteLine(urun12.adi);
                Console.WriteLine(urun11.aciklama);
                Console.WriteLine(".........................");
            }

            Console.WriteLine("---------------metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun11);
            sepetManager.Ekle(urun11);

            sepetManager.Ekle2("ayva","yesil ayva",112 ,4);
            sepetManager.Ekle2("elma", "yesil elma", 122 , 5);
            sepetManager.Ekle2("kiraz", "yesil kiraz", 132 , 6);
            sepetManager.Ekle2("kavun", "yesil kavun", 142 , 7);
          
        }
    }
}
