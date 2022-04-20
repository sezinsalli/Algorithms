using System;

namespace _1.Degiskenler1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrandan girilen değerin ondalıksayı tipinde değişkene atanması");
            Console.WriteLine("Lütfen bir değişken giriniz :");
            string degisken = Console.ReadLine();
            float dönüstür = float.Parse(degisken);
            Console.WriteLine(degisken);

        }
    }
}
