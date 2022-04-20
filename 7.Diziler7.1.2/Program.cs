using System;

namespace _7.Diziler7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] dizi1 = { "sezin", "kerem", "Fatih", "metin", "kezban" };
            for (int i = 0; i < dizi1.Length; i++)
            {
                Console.WriteLine(dizi1[dizi1.Length - i-1]);
            }
            Console.ReadLine();
        }
    }
}
