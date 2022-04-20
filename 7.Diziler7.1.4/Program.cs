using System;

namespace _7.Diziler7._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int lenght = sayılar.Length;

            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.Write($"dizi[{sayılar[i]}] ");
                i = i + 1;
                Console.WriteLine($"dizi[{sayılar[i]}]");
            }
            Console.ReadLine();


        }
    }
}
