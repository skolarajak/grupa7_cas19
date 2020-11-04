using System;
using System.Security.Cryptography;

namespace MyFirstApp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Ovo je komentar
            Console.WriteLine("Hello world."); // I ovo je komentar
            /*
             * 
             * Ovo je komentar
             * iz vise redova
             * 
             */
            Console.WriteLine("");

            double d = 2.3, dd = 4.6;
            float f = 123.45F;

            int i, j, k, l;

            Console.WriteLine(dd);
            Console.WriteLine(f);

            i = (int)d;
            f = i;

            string s = "123";
            string s2 = "Ovo je dodatni string.";
            string s3;

            s3 = Convert.ToString(Convert.ToInt32(s) + i);

            Console.WriteLine(s3);

            Console.WriteLine(i);
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
