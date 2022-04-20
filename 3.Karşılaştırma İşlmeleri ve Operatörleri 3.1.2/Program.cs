using System;

namespace _3.Karşılaştırma_İşlmeleri_ve_Operatörleri_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrandan okunan iki tam sayıyı karşılaştırma");

            Console.WriteLine("Lütfen sayı1:");
            int sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen sayı2:");
            int sayı2 = Convert.ToInt32(Console.ReadLine());

            bool isGreater = sayı1 > sayı2;
            
            bool isEqual = sayı1 == sayı2;

            Console.WriteLine(sayı1+"degerı"+sayı2+"degerınden buyuk mudur?");
            Console.WriteLine(isGreater);

            Console.WriteLine(sayı1 + "degerı" + sayı2 + "degerıne eşit midir?");
            Console.WriteLine(isEqual);
        }
    }
}
