using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)

        {
            string kurs1 = "python";
            string kurs2 = "html";
            string kurs3 = "css";
            string kurs4 = "c#";



            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array - dizi


            string[] kurslar = new string[] {"python", "html",
                "css","c#" };
        

        
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
