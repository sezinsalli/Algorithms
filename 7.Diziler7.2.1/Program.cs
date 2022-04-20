using System;

namespace _7.Diziler7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eskiDizi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Eski dizi");
            foreach (var item in eskiDizi)
            {
                Console.WriteLine(item);
            }

            int[] yeniDizi = new int[10];
            Console.WriteLine("Yeni dizi");
            for (int i = 0; i <= 9; i++)
            {
                yeniDizi[i] = eskiDizi[9-i];
                Console.WriteLine(yeniDizi[i]);

            }
            
        }
    }
}
