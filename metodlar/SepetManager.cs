using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {

        public void Ekle( Urun  urun11)
        {
            Console.WriteLine("tebrikler sepete eklendi : " + urun11 );
            


        }

        public void Ekle2(string urunadi , string aciklama , double fiyat , int stokadeti)
        { 
            Console.WriteLine("tebrikler sepete eklendi : " + urunadi);
        }
    }
}
