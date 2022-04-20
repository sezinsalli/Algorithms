using System;

namespace _1.Degiskenler1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir değişkne giriniz :");
            string sayı1 = Console.ReadLine();

            int sonuc1 = Int32.Parse(sayı1);
            Console.WriteLine(sonuc1);

        }
    }
}
