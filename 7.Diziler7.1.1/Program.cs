using System;

namespace _7.Diziler7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi elemanlarını alt alta yazdırma");
            string[] dizi1 = { "sezin", "kerem", "Fatih", "metin", "kezban" };
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
