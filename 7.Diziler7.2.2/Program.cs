using System;

namespace _7.Diziler7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 15, 60, 95, 125, 155, 745, 388, 2047, 1004, 30326 };
            int gecici;

            for (int i = 0; i < dizi.Length / 2; i++)
            {
                gecici = dizi[i];
                dizi[i] = dizi[dizi.Length - i - 1];
                dizi[dizi.Length - i - 1] = gecici;
            }
            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }
    }
}
