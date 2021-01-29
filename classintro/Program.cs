using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "yusuf";
            int yas = 19;

            kurs kurs1 = new kurs();
            kurs1.kursadi = "#c";
            kurs1.eğitmeni = "yusuf alakas";
            kurs1.izlenmeorani = "100000";

            kurs kurs2 = new kurs();
            kurs2.kursadi = "html";
            kurs2.eğitmeni = "yusuf alakas";
            kurs2.izlenmeorani = "100001";


            kurs kurs3 = new kurs();
            kurs3.kursadi = "css";
            kurs3.eğitmeni = "yusuf alakas";
            kurs3.izlenmeorani = "100002";

            //Console.WriteLine(kurs1.kursadi + ":" + kurs1.eğitmeni + ":" );

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi + ":" + kurs.eğitmeni + ":" + kurs.izlenmeorani);
            }

            Console.WriteLine("Hello World!");
        }
    }


    class kurs
    {
        public string kursadi { get; set; }
        public string eğitmeni { get; set; }
        public string izlenmeorani { get; set; }
         
    }
}
