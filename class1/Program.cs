using System;

namespace class1
{
    class Program
    {
        static void Main(string[] args)

        {
            //type safety - tip güvenliği
            //do not repeat yourself - kendini tekrarlama
            //değer tutucu , alias(takma ad)

            string kategoriEtiketi = "kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrencisayisi = 1200;
            //tam sayı
            double faizorani = 1.46;
            //kesirli sayi
            bool sistemegirişyapmişmi = false;
            //doğru yanliş 

            Console.WriteLine(ogrencisayisi);
            Console.WriteLine(faizorani);
            Console.WriteLine(sistemegirişyapmişmi);

            if (sistemegirişyapmişmi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);





        }
    }
}
