using System;

namespace _7.Diziler7._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adet giriniz :");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayılardizisi = new int[adet];
            
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Lütfen dizi elemalarını yazınız");
                sayılardizisi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sayılardizisi.Length; i++)
            {
                Console.Write(sayılardizisi[i] + "-");
            }
        }
    }
}
